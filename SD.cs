using System.Text;

namespace SMS
{
    public static class SD
    {
        public static string connString { get; set; } = @"Data Source={0}";
        public static string dbPath { get; set; } = null;
        static SD()
        {
            string basePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            SD.dbPath = Path.Combine(basePath, "app.db");
            StringBuilder sb = new StringBuilder();
            SD.connString = sb.AppendFormat(SD.connString, SD.dbPath).ToString();

        }
    }
}
