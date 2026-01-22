using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy02 : MonoBehaviour
{
    Transform player;

    public GameObject bulletPrefab;
    public float bulletSpeed = 1.0f;

    void Start()
    {
        player = GameObject.Find("Player").transform;
        InvokeRepeating("Attack", 1f, 3f);
    }

    void Update()
    {
        if (player != null)
        {
            Vector3 direction = player.position - transform.position;
            transform.right = -direction;
        }
    }

    void Attack()
    {
        if (player == null)
        {
            return;
        }
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        if (rb != null)
        {
            Vector2 shootDirection = (player.position  - transform.position).normalized;
            rb.linearVelocity = shootDirection * bulletSpeed;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.SetActive(false);
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }
}