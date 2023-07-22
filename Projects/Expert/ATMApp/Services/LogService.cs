namespace ATMApp.Services
{
    public class LogService
    {
        private List<string> _logs = new();

        public void AddLog(string log)
        {
            _logs.Add(log);
        }

        public IEnumerable<string> GetLogs()
        {
            return _logs;
        }
    }    
}
