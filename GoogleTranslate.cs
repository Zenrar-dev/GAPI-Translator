using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

public class GoogleTranslate
{
    private static readonly HttpClient client = new HttpClient();
    private static readonly Dictionary<string, string> languages = new Dictionary<string, string>
    {
        { "Азербайджанский", "az" },
        { "Албанский", "sq" },
        { "Амхарский", "am" },
        { "Английский", "en" },
        { "Арабский", "ar" },
        { "Армянский", "hy" },
        { "Африкаанс", "af" },
        { "Баскский", "eu" },
        { "Белорусский", "be" },
        { "Бенгальский", "bn" },
        { "Болгарский", "bg" },
        { "Боснийский", "bs" },
        { "Валлийский", "cy" },
        { "Венгерский", "hu" },
        { "Вьетнамский", "vi" },
        { "Гаитянский креольский", "ht" },
        { "Галисийский", "gl" },
        { "Голландский", "nl" },
        { "Греческий", "el" },
        { "Грузинский", "ka" },
        { "Гуджарати", "gu" },
        { "Датский", "da" },
        { "Иврит", "iw" },
        { "Зулу", "zu" },
        { "Игбо", "ig" },
        { "Идиш", "yi" },
        { "Индонезийский", "id" },
        { "Ирландский", "ga" },
        { "Исландский", "is" },
        { "Испанский", "es" },
        { "Итальянский", "it" },
        { "Йоруба", "yo" },
        { "Казах", "kk" },
        { "Каннада", "kn" },
        { "Каталанский", "ca" },
        { "Киньяруанда", "rw" },
        { "Киргиз", "ky" },
        { "Корейский", "ko" },
        { "Корсиканский", "co" },
        { "Курдский", "ku" },
        { "Кхмерский", "km" },
        { "Лаосский", "lo" },
        { "Латинский", "la" },
        { "Латышский", "lv" },
        { "Литовский", "lt" },
        { "Люксембургский", "lb" },
        { "Македонский", "mk" },
        { "Малагасийский", "mg" },
        { "Малайский", "ms" },
        { "Малаялам", "ml" },
        { "Мальтийский", "mt" },
        { "Маори", "mi" },
        { "Маратхи", "mr" },
        { "Монгольский", "mn" },
        { "Мьянманский (бирманский)", "my" },
        { "Немецкий", "de" },
        { "Непальский", "ne" },
        { "Норвежский", "no" },
        { "Ньянджа (чичева)", "ny" },
        { "Одия (Ория)", "or" },
        { "Панджаби", "pa" },
        { "Персидский", "fa" },
        { "Польский", "pl" },
        { "Португальский", "pt" },
        { "Пушту", "ps" },
        { "Румынский", "ro" },
        { "Русский", "ru" },
        { "Самоанский", "sm" },
        { "Сербский", "sr" },
        { "Сесото", "st" },
        { "Сингальский", "si" },
        { "Синдхи", "sd" },
        { "Словацкий", "sk" },
        { "Словенский", "sl" },
        { "Сомалийский", "so" },
        { "Суахили", "sw" },
        { "Сунданский", "su" },
        { "Тагальский", "tl" },
        { "Таджикский", "tg" },
        { "Тайский", "th" },
        { "Тамильский", "ta" },
        { "Татарин", "tt" },
        { "Телугу", "te" },
        { "Турецкий", "tr" },
        { "Туркменский", "tk" },
        { "Узбекский", "uz" },
        { "Уйгурский", "ug" },
        { "Украинский", "uk" },
        { "Урду", "ur" },
        { "Финский", "fi" },
        { "Французский", "fr" },
        { "Фризский", "fy" },
        { "Хауса", "ha" },
        { "Хинди", "hi" },
        { "Хорватский", "hr" },
        { "Хоса", "xh" },
        { "Чешский", "cs" },
        { "Шведский", "sv" },
        { "Шона", "sn" },
        { "Шотландский гэльский", "gd" },
        { "Эсперанто", "eo" },
        { "Эстонский", "et" },
        { "Яванский", "jv" },
        { "Японский", "ja" }

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
