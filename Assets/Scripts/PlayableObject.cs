using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayableObject : MonoBehaviour
{
    public Health health = new Health();

    public Weapon weapon;

    public virtual void Move()
    {
        Debug.Log($"BASE: Moving");
    }

    public virtual void Shoot(Vector3 direction, float speed)
    {
        Debug.Log($"BASE: Shooting a bullet towards {direction}, with a speed of {speed}");
    }

    public virtual void Die()
    {
        Debug.Log($"BASE: Player Died");
    }

    public virtual void Attack(float interval)
    {
        Debug.Log($"BASE: Enemy attacking with a {interval}, interval");
    }
}
