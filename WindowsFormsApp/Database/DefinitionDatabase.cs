using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Dictionary.Database
{
    public class DefinitionDatabase
    {
        private readonly HttpClient _httpClient = new HttpClient();

        private async Task<string> GetDictionaryDefinitionAsync(string word)
        {
            try
            {
                string apiUrl = $"https://api.dictionaryapi.dev/api/v2/entries/en/{word}";
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    

                    return await response.Content.ReadAsStringAsync();
                }
                return "Word not found";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}
