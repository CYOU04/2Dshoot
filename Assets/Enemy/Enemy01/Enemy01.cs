using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy01 : MonoBehaviour
{
    private Rigidbody2D rb;
    private float OriginalAttackSpeed = -2f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        float CurrentSpeed = GameManager.Instance.GetCurrentSpeed(OriginalAttackSpeed);

        rb.linearVelocity = transform.right * CurrentSpeed * Random.Range(0.8f, 1.2f);
    }

    void Update()
    {
        if (transform.position.x < -12f)
        {
            Destroy(gameObject);
            PlayerController.HP -= 1;
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
