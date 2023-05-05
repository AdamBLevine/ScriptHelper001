using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenAI_API;
using OpenAI_API.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ScriptHelper
{
    public class MyGPT
    {
        public static async Task<string> JimRutt(IOpenAIAPI api, string input, string model)
        {


            var chat = api.Chat.CreateConversation();
            chat.RequestParameters.Model = model;

            /// give instruction as System
            chat.AppendSystemMessage("You are a smart assistant");

            chat.AppendUserInput(input);


            // and get the response
            string response = await chat.GetResponseFromChatbotAsync();
            Console.WriteLine(response);
            return response;
        }

        public static async Task<string> makeMovieText(IOpenAIAPI api, string input, string model,Form1 myForm)
        {
            string systemPrompt = "";
            string userPrompt = "";
            string errorMsg = "";
            
            if (model == "gpt-3.5-turbo")
            {
                systemPrompt = "you are a helpful assitant.  You are working with a movie screenwriteer to help write a movie script.";
                userPrompt = @" We are working on a movie script.  Below will be some hints about the movie.  Do not provide a title for the movie. 
 In the hints character names will be enclosed in angle brackets <>.  Example: <Mary>. Please use the hints to write a detailed description of what
 the movie is about.  As needed, create additional characters. 
 In the output use first names for the characters and for every occurance of a character's name, always enclose the character names within angle brackets, example <Sally>. ";
                userPrompt += "Here are the hints to use for writing movie description: ";
                userPrompt += input;
            }
            else if (model == "gpt-4")

            {
                systemPrompt = @" We are working on a movie script.  Below will be some hints about the movie.  Do not provide a title for the movie. 
 In the hints character names will be enclosed in angle brackets <>.  Example: <Mary>. Please use the hints to write a detailed description of what
 the movie is about.  As needed, create additional characters. 
 In the output use first names for the characters and always enclose the character names within angle brackets, example <Sally>. ";
                userPrompt = input;
            }

            else

            {
                Console.WriteLine("Bad model");
                Application.Exit();

            }


            string response = await UtilsGPT.doGPT(api, model, 500, .7, userPrompt, systemPrompt, errorMsg, myForm);

            return response;
        }



        public static async Task<string> makeScenesFromMovieText(IOpenAIAPI api, string input, string model, int sceneKount, int sentences, string errorOut,Form1 myForm)
        {

            string systemPrompt, userPrompt;
            systemPrompt = "";
            userPrompt = "";

            if (model == "gpt-3.5-turbo")
            {
                systemPrompt = "you are a helpful assistant working with a screenwriter to develop a movie script";
                systemPrompt += " Your output will be in JSON as a list of lists containing all of the scenes. In this form:";
                systemPrompt += "[[\"scene title\",\"scene description\"],[\"scene title\",\"scene description\"],[\"scene title\",\"scene description\"]]";

                userPrompt = " We are working on a movie script.  Below you will find a description of the movie.";
                userPrompt += " Please output " + sceneKount.ToString() + " scenes for the movie.";
                userPrompt += " Each scene should include a title and a description of the action in that scene. Do not include scene numbers.";
                userPrompt += " In the description every occurance of every character name must be enclosed in angle brackets <>.  Example <Robert>.";

                userPrompt += $"Each scene description should be at least {sentences} sentences long.  This is the movie description to make into scenes: ";
                userPrompt += input;
                userPrompt += " Your output will be in JSON as a list of lists containing all of the scenes. In this form:";
                userPrompt += "[[\"scene title\",\"scene description\"],[\"scene title\",\"scene description\"],[\"scene title\",\"scene description\"]]";



            }
            else if (model == "gpt-4")
            {
                systemPrompt = " We are working on a movie script.  The user prompt will provide a description of the movie.";
                systemPrompt += " Please output " + sceneKount.ToString() + " scenes for the movie.";
                systemPrompt += " Each scene should include a title and a description of the action in that scene. ";
                systemPrompt += " In the description every occurance of a character's name must be enclosed in angle brackets <>.  Example <Robert>.";
                systemPrompt += " Do not include scene numbers.  Your output will be as a JSON list of lists.  Thee outer list will be a list of inner lists. Each of the inner lists consisting of two elements: ";
                systemPrompt += " The first element of each inner list is the title as a string.  The second element in the inner list is the description as a string.";
                userPrompt = input;
            }


            string response = await UtilsGPT.doGPT(api, model, 1500, .7, userPrompt, systemPrompt, errorOut,myForm);

           


            return response;
        }
        public static async Task<string> makeSceneText(IOpenAIAPI api, string model, MovieObj myMovie, List<SceneObj> sceneList, int sceneNum,Form1 myForm)
        {
            string userPrompt = "";
            string  errorMsg = "";
            string systemPrompt = @" You are an assistant helping a screenwriter write a movie script
Your task will be take a scene hint that is provided in the user prompt and to write a detailed narrative description of the movie scene.

Below is the movie synposis that describes the movie as a whole: \r\n";
            systemPrompt += myMovie.movieText;

            systemPrompt += "here are the scenes that come prior to the scene you will be writing:\r\n";

            int sceneKount = 0;
            string sceneKountStr;
            foreach (SceneObj myScene in sceneList)
            {
                sceneKount += 1;
                if (sceneKount < sceneNum)
                {
                    sceneKountStr = sceneKount.ToString();
                    systemPrompt += $"Scene {sceneKountStr}:" + myScene.Title + "\r\n";
                    systemPrompt += myScene.Description + "\r\n";

                }
                else
                {
                    break;
                }


            }

            userPrompt = "\r\n Be sure to add one space after sentence. ";
            userPrompt += "Enclose all names of persons or characters in angle brackets <>.  Example <Robert>. ";
            userPrompt += "Please write a detailed narrative scene description from this scene hint: " + sceneList[sceneNum - 1].Description;


            string response = await UtilsGPT.doGPT(api, model, 500, .7, userPrompt, systemPrompt, errorMsg, myForm);
                                   
            return response;
        }
        public static async Task<string> gptCompress(IOpenAIAPI api, string input, string model, int maxTokens,Form1 myForm)
        {

            string errorMsg = "";
            string systemPrompt = @"compress the user prompt text such that you (GPT) 
can reconstruct the intention of the human who wrote text with the full original intention. 
This is for yourself. It does not need to be human readable or understandable. Abuse of language mixing, 
abbreviations, symbols (unicode and emoji), or any other encodings or internal representations is all permissible, 
so long as it, used in a future prompt will yield near-identical results as the original text:";

            string userPrompt = input;

            string response = await UtilsGPT.doGPT(api, model, maxTokens, .7, userPrompt, systemPrompt, errorMsg, myForm);

            
            return response;

        }

        public static async Task<string> getTitle(IOpenAIAPI api, string input, string model,Form1 myForm)

        {
            string errorMsg = "";
            string systemPrompt = @" We are working on a movie script.  The user prompt will be a description of the
 movie.  Please return a title. ";
            string userPrompt = input;
            string response = await UtilsGPT.doGPT(api, model, 50, .7, userPrompt, systemPrompt, errorMsg, myForm);
            response = response.Replace("\"", "");
            return response;
        }

        public static async Task<String> fixJSON(IOpenAIAPI api, string input, string model, Form1 myForm )
        {
            string errorMsg = "";
            
            string systemPrompt = "you will repair the errors in the JSON file provided in the user prompt";
            string userPrompt = input;
            
            string response = await UtilsGPT.doGPT(api, model, 2000, .7, userPrompt, systemPrompt, errorMsg, myForm);
            
            return response;
        }

        public static async Task<string> makeBeatSheet(IOpenAIAPI api, MovieObj myMovie,  string sceneText, string model,Form1 myForm)
        {
            string userPrompt = "";
            string errorMsg = "";
            string systemPrompt = " You are an assistant helping a screenwriter write a movie script";
            systemPrompt += "Below is a synposis that describes the movie as a whole: \r\n";
            systemPrompt += myMovie.movieText;

            systemPrompt += "Your task will be create a scene beat sheet for the scene description in the user prompt.";



            userPrompt = @"A beat sheet  breaks down a scene into a 
series of beats or moments that are essential for moving the plot forward. These beats can include 
character introductions, important decisions, emotional turning points, conflicts, and resolutions.
The beat sheet is organized in a linear or chronological order. Do not include anyt Acts or Act numbers in the beat sheet";

            userPrompt = "\r\n Please write a beat sheet for the following scene description: \r\n";
            
            userPrompt += sceneText;


            string response = await UtilsGPT.doGPT(api, model, 1000, .7, userPrompt, systemPrompt, errorMsg, myForm );
            // string response = await chat.GetResponseFromChatbotAsync();

            return response;    
        }

        public static async Task<string> makeSceneScript(IOpenAIAPI api, MovieObj myMovie, string beatSheet, string sceneText, string model,Form1 myForm)
        {
            string errorMsg = "";
            string userPrompt = "";
            string systemPrompt = " You are an assistant helping a screenwriter write a movie script.";
            systemPrompt += "Below is a synposis that describes the movie as a whole: \r\n";
            systemPrompt += myMovie.movieText;
            systemPrompt += "Below is a detailed scene description. \r\n";
            systemPrompt += sceneText;
            systemPrompt += "\r\n Your task will be write the script for one scene using the scene beat sheet in the user prompt.";



            

            userPrompt = "Please write a scene in screenplay format from the scene description and beat sheat: \r\n";
            userPrompt += "Scene decsription: " + sceneText;
            userPrompt += "\r\n The beat sheet: ";
            userPrompt += beatSheet;
            
            // userPrompt += "\r\n Please return the beat sheet as a list of strings in JSON format ";


            string response = await UtilsGPT.doGPT(api, model, 2000, .7, userPrompt, systemPrompt, errorMsg, myForm);
            
            /*var chat = api.Chat.CreateConversation();
            chat.RequestParameters.Model = model;
            chat.RequestParameters.MaxTokens = 2000;

            chat.AppendSystemMessage(systemPrompt);

            chat.AppendUserInput(userPrompt);

            string response = await chat.GetResponseFromChatbotAsync(); */

            return response;
        }


        public static async Task<string> NotesForMovieText(IOpenAIAPI api, string model, MovieObj myMovie, string textNote, Form1 myForm)
        {
            string errorMsg = "";
            string systemPrompt = " You are an assistant helping a screenwriter write a movie script. ";
            systemPrompt += "In the user prompt you will be provided with a detailed narrative description of the movie.";
            systemPrompt += " You will also be provided with \'notes\' which are instructions for rewriting the detailed narrative description of the movie. ";
            systemPrompt += " You will rewrite the detailed narrative description of the movie taking into consideration the notes. To the degree possible, unless instructed otherwise by the \'note\' ";
            systemPrompt += " you will retain all the details from the original version. ";


            string userPrompt = "Here is the detailed narrative description of the movie: \r\n";
            userPrompt += myMovie.movieText;
            userPrompt += "\r\n Here are the notes to use for rewriting the detailed narrative description of the movie: \r\n ";
            userPrompt += textNote;
            userPrompt += " Please rewrite the detailed narrative description of the movie considering the notes";
            string response = await UtilsGPT.doGPT(api, model, 2000, .7, userPrompt, systemPrompt, errorMsg, myForm);

            return response;
        }


    }
}
