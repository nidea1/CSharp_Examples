namespace ATMApp.Services
{
    public class EODService
    {
        public void SaveEndOfDay(IEnumerable<string> logs)
        {
            string date = DateTime.Now.ToString("ddMMyyyy");
            string path = $"EOD_{date}.txt";

            File.WriteAllLines(path, logs);
        }
    }
}
