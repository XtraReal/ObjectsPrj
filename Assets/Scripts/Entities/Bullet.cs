using UnityEngine;

public class Bullet 
{
    private float damage;

    void Move(Transform target)
    {
        Debug.Log($"Bullet moving towards {target.name} to deal {damage}pts damage");
    }

    private void Damage()
    {
        Debug.Log($"Damaged Something");
    }
}
