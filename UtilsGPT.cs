using OpenAI_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ScriptHelper
{
    internal class UtilsGPT
    {
        public static async Task<string> doGPT(IOpenAIAPI api, string model, int tokenMax, double temperature, string userPrompt, string systemPrompt,string errorOut)
        {
            string errorMsg = "";
            string response = "";
            int errorKount = 0;
            Boolean looper = true;
            while (looper)
            {
                try
                {
                    response = "";
                    var chat = api.Chat.CreateConversation();
                    chat.RequestParameters.Model = model;
                    chat.RequestParameters.MaxTokens = tokenMax;

                    chat.AppendSystemMessage(systemPrompt);

                    chat.AppendUserInput(userPrompt);
                    response = await chat.GetResponseFromChatbotAsync();
                    looper = false;
                }
                catch (Exception ex)
                {
                    errorKount += 1;
                    errorMsg = "GPT busy error kount = " + errorKount.ToString();
                    Console.WriteLine(errorMsg);
                    Thread.Sleep(750);
                    if (errorKount > 5) looper = false;
                }
            
            }
            

            return response;


        }
            
    }
}
