using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private float speed;

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
            Debug.Log($"Damaged Something");
            Destroy(gameObject);
        }
        Debug.Log($"Damaged Something");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Bullet collided with" + collision.gameObject.name);

        // Using interface
        IDamageable damageable = collision.GetComponent<IDamageable>();
        Damage(damageable);
    }
}
