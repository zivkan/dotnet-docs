﻿using Azure.AI.OpenAI;
using Azure.Identity;
using Microsoft.Extensions.AI;

IChatClient client =
    new AzureOpenAIClient(
        new Uri("YOUR_MODEL_ENDPOINT"),
        new DefaultAzureCredential()).AsChatClient("YOUR_MODEL_DEPLOYMENT_NAME");

try
{
    ChatResponse completion = await client.GetResponseAsync("YOUR_PROMPT");

    Console.WriteLine(completion.Messages.Single());
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
