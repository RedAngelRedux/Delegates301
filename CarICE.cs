

namespace Delegate301;

public class CarICE : Car
{
    public override string GetCarDetails()
    {
        return $"{base.GetCarDetails()} - Internal Combustion Engine";
    }
}

delegate void LogICECarDetails(CarICE? car);

