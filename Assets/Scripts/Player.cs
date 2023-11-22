using UnityEngine;

public class Player : PlayableObject
{
    private string nickName;
    [SerializeField] private Camera cam;
    [SerializeField] private float speed;

    private Rigidbody2D playerRB;

    private void Start()
    {
        //Move();
        Shoot(Vector3.zero, speed);
        Die();
    }

    public override void Shoot(Vector3 direction, float speed)
    {
        Debug.Log($"Shooting a bullet towards {direction}, with a speed of {speed}");
    }

    public override void Die()
    {
        Debug.Log("Player Died");
    }

    public override void Move(Vector2 direction, Vector2 target)
    {
        playerRB.velocity = direction * speed * Time.deltaTime;
        var playerScreenPos = cam.WorldToScreenPoint(transform.position); // lets us get our (x,y) coordinates for our player
    }

    public override void Attack(float interval)
    {

    }
}
