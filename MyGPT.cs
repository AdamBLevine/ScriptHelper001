using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenAI_API;

namespace ScriptHelper
{
    public class MyGPT
    {
        public static async Task<string> JimRutt(IOpenAIAPI api , string input, string model)
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

        public static async Task<string> makeMovieText(IOpenAIAPI api , string input, string model)
        {
            string systemPrompt = @" We are working on a movie script.  The user prompt will be some hints about the movie.  Please use those hints to write a detailed description of what
the movie is about. Do not provide any names for the characters.  Enclose the description in square brackets like these []. ";


            var chat = api.Chat.CreateConversation();
            chat.RequestParameters.Model = model;

            // chat.RequestParameters.Model = ;
            chat.RequestParameters.MaxTokens = 500;
            string x = chat.RequestParameters.Model.ToString();
            /// give instruction as System
            chat.AppendSystemMessage(systemPrompt);

            chat.AppendUserInput(input);
            
            string response = await chat.GetResponseFromChatbotAsync();

            return response;     
        }

        public static async Task<string> makeMovieCompiledText(IOpenAIAPI api, string input, string model)
        {
            string systemPrompt = @" We are working on a movie script.  The user prompt will be a long form description
of the movie. Please compress the description but do so in a way that will allow you to understand every detail in it.
It should consist of English words with spaces between them, but need not contain punctuation or be grammatically correct. 
It does not need to be easily human readbable. Enclose the compressed description in square brackets like these []. ";

            var chat = api.Chat.CreateConversation();
            chat.RequestParameters.Model = model;
            // chat.RequestParameters.Model = "gpt-3.5-turbo";
            chat.RequestParameters.MaxTokens = 500;
            string x = chat.RequestParameters.Model.ToString();
            /// give instruction as System
            chat.AppendSystemMessage(systemPrompt);

            chat.AppendUserInput(input);

            string response = await chat.GetResponseFromChatbotAsync();

            return response;
        }

        public static async Task<string> makeScenesFromMovieText(IOpenAIAPI api, string input, string model, int sceneKount)
        {
            string systemPrompt = " We are working on a movie script.  The user prompt will provide a description of the movie.";
            systemPrompt += " Please output " + sceneKount.ToString() + " scenes for the movie.";
            systemPrompt += " Each scene should include a title and a description of the action in that scene enclosed. ";
            systemPrompt += " Do not include scene numbers.  Output as JSON list of lists with each of the inner list consisting of ";
            systemPrompt +=   " first the title as a string then the description as a string.";




            var chat = api.Chat.CreateConversation();
            chat.RequestParameters.Model = model;
            chat.RequestParameters.MaxTokens = 3000;

            // chat.RequestParameters.Model = ;
            chat.RequestParameters.MaxTokens = 500;
            string x = chat.RequestParameters.Model.ToString();
            /// give instruction as System
            chat.AppendSystemMessage(systemPrompt);

            chat.AppendUserInput(input);

            string response = await chat.GetResponseFromChatbotAsync();

            return response;
        }
    }
}
