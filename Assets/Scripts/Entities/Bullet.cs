using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private float speed;

    private string targetTag;

    public void SetBullet(float _damage, string _targetTag, float _speed = 10.0f)
    {
        this.damage = _damage;
        this.speed = _speed;
        this.targetTag = _targetTag;

    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        Debug.Log($"Bullet moving to deal {damage}pts damage");
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void Damage(IDamageable damageable)
    {
        if (damageable != null)
        {
            damageable.GetDamage(damage);

            GameManager.GetInstance().scoreManager.IncrementScore();
            Debug.Log($"Damaged Something");
            Destroy(gameObject);
        }
        Debug.Log($"Damaged Something");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Bullet collided with" + collision.gameObject.name);

        // Check the target
        if (!collision.gameObject.CompareTag(targetTag)) // Don't do damage if this isn't the correct target
        {
            return;
        }

        // Using interface
        IDamageable damageable = collision.GetComponent<IDamageable>();
        Damage(damageable);
    }
}
