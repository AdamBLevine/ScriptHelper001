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
        public static async Task<string> JimRutt(IOpenAIAPI api , string input)
        {

            
            var chat = api.Chat.CreateConversation();

            /// give instruction as System
            chat.AppendSystemMessage("You are a smart assistant");

            chat.AppendUserInput(input);
           

            // and get the response
            string response = await chat.GetResponseFromChatbotAsync();
            Console.WriteLine(response);
            return response;
        }

        public static async Task<string> makeMovieText(IOpenAIAPI api , string input)
        {
            string systemPrompt = @" We are working on a movie script.  The user prompt will be some hints about the movie.  Please use those hints to write a detailed description of what
the movie is about. Enclose the description in square brackets like these []";

            var chat = api.Chat.CreateConversation();
            chat.RequestParameters.Model = "gpt-4";
            // chat.RequestParameters.Model = "gpt-3.5-turbo";
            chat.RequestParameters.MaxTokens = 500;
            string x = chat.RequestParameters.Model.ToString();
            /// give instruction as System
            chat.AppendSystemMessage(systemPrompt);

            chat.AppendUserInput(input);
            
            string response = await chat.GetResponseFromChatbotAsync();
            
            return Utils.TextBetweenBrackets(response);        }
    }
}
