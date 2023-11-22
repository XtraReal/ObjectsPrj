using UnityEngine;

public class ElectricCar : Car
{
    private float kW;
    private float distanceTraveled;

    private void Start()
    {
        GasPerMile(kW, distanceTraveled);
    }

    public override float GasPerMile(float _kW, float _distance)
    {
        return base.GasPerMile(_kW, _distance);
    }
}
