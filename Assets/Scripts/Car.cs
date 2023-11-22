using UnityEngine;

public class Car
{
    public virtual float GasPerMile(float _gasUsed, float _distance)
    {
        return _gasUsed / _distance;
    }
}
