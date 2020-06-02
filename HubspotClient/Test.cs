using System;
using System.Net.Http;

namespace HubspotClient
{
    class Test
    {
        public async void Get()
        {
            try
            {
                var httpClient = new HttpClient();
                var uri = new Uri("https://api.hubapi.com/crm/v3/objects/companies?hapikey=b4854144-aa95-41bb-b016-b917cb696b3f");
                var response = await httpClient.GetAsync(uri);
                Console.WriteLine(await response.Content.ReadAsStringAsync());
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
