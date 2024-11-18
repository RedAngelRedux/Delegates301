
namespace Delegate301;

public static class CarFactory
{
    public static CarICE ReturnCarICE(int id, string name) { return new CarICE() {Id = id, Name = name }; }
    public static CarEV ReturnCarEV(int id, string name) { return new CarEV() {Id = id,Name = name}; }

    public static void LogCarDetails(Car? car)
    {
        string fileName;
        string logMessage;

        if (car is CarICE)
        {
            fileName = "ice-details.log";
            logMessage = $"Object Type:  {car.GetType()}{Environment.NewLine}Car Details:  {car.GetCarDetails()}";
        }
        else if (car is CarEV)
        {
            fileName = "ev-details.log";
            logMessage = $"Object Type:  {car.GetType()}{Environment.NewLine}Car Details:  {car.GetCarDetails()}";
        }
        else
        {
            throw new ArgumentException($"{car} is not derived from Car.");
        }

        using StreamWriter sw = new (Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName), true);
        sw.WriteLine(logMessage);
    }
}

delegate Car CarFactoryDlgt(int id, string name);
