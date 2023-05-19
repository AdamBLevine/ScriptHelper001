# ScriptHelper001
Window based movie scriptwriting tool using GPT

# Important Note about C# OpenAI-API-dotnet Library
For long running processes (pretty much anything running in GPT-4 mode), the NuGet version 1.7.2 of the library 
will timneout after 100 seconds.  The library doesn't offer a way to set the timeout.
I have modified the library to increase the timeout to 1000 seconds.  That is a quick and dirty hack, but it works.
I have uploaded my modified version as OpenAI_API.dll into the project.  DO NOT use the NuGet version until they fix the problem.
There is a github issue open on the problem.  You can monitor it to see if and when they fix it: 
https://github.com/OkGoDoIt/OpenAI-API-dotnet/issues/102
