using UnityEngine;

public class Weapon
{
    private string weaponName;
    private float damage;


    public Weapon()
    {

    }

    public Weapon(string _weaponName, float _damage)
    {
        weaponName = _weaponName;
        damage = _damage;
    }

    public void Shoot()
    {
        Debug.Log($"Shooting from weapon");
    }
}
