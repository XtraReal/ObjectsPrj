using UnityEngine;

public class Player : PlayableObject
{
    private string nickName;
    private float speed;

    private void Start()
    {
        Move();
        Shoot(Vector3.zero, speed);
        Die();
    }

    public override void Move()
    {
        base.Move();
        Debug.Log($"Player Moving");
    }

    public override void Shoot(Vector3 direction, float speed)
    {
        base.Shoot(direction, speed);
        Debug.Log($"Shooting a bullet towards {direction}, with a speed of {speed}");
    }

    public override void Die()
    {
        base.Die();
        Debug.Log("Player Died");
    }
}
