using UnityEditor;

namespace GoogleImporter
{
    public class ConfigImportsMenu
    {
        private static string ITEMS_SHEETS_NAME = "LanguageLibrary";
        private static string CREDENTIALS_PAHTH = "language-runner-20a956f9695d.json";
        private const string SpreadsheetID = "1p6kab7o2S6QUCZwDyqmX9CNdiKn3cHCEUpXTKnuEOr0";

        [MenuItem("NikRunner/Import Google Sheets")]
        public static async void LoadSheetsSettings()
        {
            var sheetsImporter = new GoogleSheetsImporter(CREDENTIALS_PAHTH, SpreadsheetID);
            var config = new Config();
            var parser = new GoogleParser(config);
            await sheetsImporter.DownloadAndParseSheet(ITEMS_SHEETS_NAME,parser);
        }
    }
}