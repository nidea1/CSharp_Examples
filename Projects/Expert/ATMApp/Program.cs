using ATMApp.Services;

namespace ATMApp
{
    class Program
    {
        static void Main()
        {
            AuthenticationService authService = new();
            LogService logService = new();
            EODService eodService = new();

            ATM.ATM atm = new(authService, logService, eodService);
            atm.Start();
        }
    }
}
