using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;


namespace Dictionary.Database
{
    public class DefinitionDatabase
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://api.dictionaryapi.dev/api/v2/entries/en/";
        private const string UrbanDictionaryBaseUrl = "https://obscure-yodel-gvgg9px5rrqh9pwx-3000.app.github.dev/?defid=";


        public async Task<WordDefinition[]> GetDef(string word, bool urbanDictionary)
        {
            try
            {
                var response = await _httpClient.GetStringAsync($"{(urbanDictionary ? UrbanDictionaryBaseUrl : BaseUrl)}{word.ToLower().Trim()}");
                return urbanDictionary ? new WordDefinition[] { new WordDefinition() { 
                    Meanings = new List<Meaning>()
                    {
                        new Meaning()
                        {
                            Definitions = new List<Definition>() { 
                                new Definition() { 
                                    Text = response
                                } 
                            },
                            PartOfSpeech = "Urban Dictionary"
                        }
                    }
                } } : JsonConvert.DeserializeObject<WordDefinition[]>(response);
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Failed to fetch definition for word: {word}", ex);
            }
            catch (JsonException ex)
            {
                throw new Exception($"Failed to parse definition response for word: {word}", ex);
            }
        }

        public class WordDefinition
        {
            [JsonProperty("word")]
            public string Word { get; set; }

            [JsonProperty("phonetic")]
            public string Phonetic { get; set; }

            [JsonProperty("phonetics")]
            public List<Phonetic> Phonetics { get; set; }

            [JsonProperty("meanings")]
            public List<Meaning> Meanings { get; set; }

            [JsonProperty("license")]
            public License License { get; set; }

            [JsonProperty("sourceUrls")]
            public List<string> SourceUrls { get; set; }
        }

        public class Phonetic
        {
            [JsonProperty("text")]
            public string Text { get; set; }

            [JsonProperty("audio")]
            public string Audio { get; set; }

            [JsonProperty("sourceUrl")]
            public string SourceUrl { get; set; }

            [JsonProperty("license")]
            public License License { get; set; }
        }

        public class Meaning
        {
            [JsonProperty("partOfSpeech")]
            public string PartOfSpeech { get; set; }

            [JsonProperty("definitions")]
            public List<Definition> Definitions { get; set; }

            [JsonProperty("synonyms")]
            public List<string> Synonyms { get; set; }

            [JsonProperty("antonyms")]
            public List<string> Antonyms { get; set; }
        }

        public class Definition
        {
            [JsonProperty("definition")]
            public string Text { get; set; }

            [JsonProperty("synonyms")]
            public List<string> Synonyms { get; set; }

            [JsonProperty("antonyms")]
            public List<string> Antonyms { get; set; }

            [JsonProperty("example")]
            public string Example { get; set; }
        }

        public class License
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }
        }


        public DefinitionDatabase()
        {
            _httpClient = new HttpClient();
        }

    }
}
