

namespace Delegate301;

public class CarEV : Car
{
    public override string GetCarDetails()
    {
        return $"{base.GetCarDetails()} - Electric Vehicle";
    }
}

delegate void LogEVCarDetails(CarEV? car);


