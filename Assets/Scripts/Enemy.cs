using UnityEngine;

public class Enemy : PlayableObject
{
    private string enemyName;
    private float speed;
    private EnemyType enemyType;

    private void Start()
    {
        Move(transform);
        Shoot(Vector3.zero, 2.0f);
        Die();
        Attack(2.0f);
    }

    public void Move(Transform target)
    {
        Debug.Log($"Moving towards the target {target.name}");
    }

    public override void Shoot(Vector3 direction, float speed)
    {
        base.Shoot(direction, speed);
        Debug.Log($"Shooting a bullet towards {direction} with a speed of {speed}");
    }

    public override void Die()
    {
        base.Die();
        Debug.Log("Player Died");
    }

    public override void Attack(float interval)
    {
        base.Attack(2.0f);
        Debug.Log($"Enemy attacking with a {interval}, interval");
    }

    public void setEnemyType (EnemyType _enemyType)
    {
        enemyType = _enemyType;
    }
}
