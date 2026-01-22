using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public PlayerController PlayerController;

    public float bulletSpeed = 10f;
    
    private Rigidbody2D rb;

    public static float Score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.right * bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
     //   transform.Translate(Vector3.right *  bulletSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Score += 1;
        }
    }
}
