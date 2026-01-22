using UnityEngine;
using UnityEngine.SceneManagement;

public class StaminaRecover : MonoBehaviour
{
    private Rigidbody2D rb;
    float Speed = -2f;

    void Start()
    {
        //this.Speed = 2f + 1f * Random.value;
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.right * Speed * Random.Range(0.9f, 2f);
    }

    void Update()
    {
        //transform.Translate(-Speed * Time.deltaTime, 0, 0, Space.World);
        if (transform.position.x < -12f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (PlayerController.Stamina >= 50)
            {
                PlayerController.Stamina = 100;
            }
            else
            {
                PlayerController.Stamina += 50;
            }  
            Debug.Log("Stamina recovered");
            Destroy(gameObject);
        }
    }
}
