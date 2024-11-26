using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

public class GoogleTranslate
{
    private static readonly HttpClient client = new HttpClient();
    private static readonly Dictionary<string, string> languages = new Dictionary<string, string>
    {
        { "Английский", "en" },
        { "Русский", "ru" },
        { "Французский", "fr" },
        { "Немецкий", "de" },
        { "Испанский", "es" },
        { "Итальянский", "it" },
        { "Португальский", "pt" }
    };
    private static readonly string urlTemplate = "https://clients5.google.com/translate_a/t?client=dict-chrome-ex&sl={0}&tl={1}&q={2}";
    private static string ExtractTranslatedText(string responseBody)
    {
        int startIdx = responseBody.IndexOf("[\"") + 2;
        int endIdx = responseBody.IndexOf("\"]", startIdx);
        string translatedText = responseBody.Substring(startIdx, endIdx - startIdx);
        return translatedText;
    }
    public static async Task<string> TranslateAsync(string fromLanguage, string toLanguage, string textToTranslate)
    {
            string sl = languages[fromLanguage];
            string tl = languages[toLanguage];
            string url = string.Format(urlTemplate, sl, tl, Uri.EscapeDataString(textToTranslate));
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            string translatedText = ExtractTranslatedText(responseBody);
            return translatedText;
    } 
}
