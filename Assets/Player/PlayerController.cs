using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    float OriginalSpeed = 2f;
    float CurrentSpeed;
    private float minX = -8f, maxX = 8f;
    private float minY = -4f, maxY = 4f;

    public static bool isrunning;
    public static float Stamina = 100;
    public Text StaminaText;

    public GameObject bulletPrefab;
    public Transform shootingPoint;

    public Text ScoreText;

    public static float HP = 3;
    public Text HPText;

    void Start()
    {
        Application.targetFrameRate = 60;
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (MenuManage.isPaused == true)
        {
            Rigidbody2D.linearVelocity = Vector2.zero;
            return;
        }
        
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector2 Movement = new Vector2(moveX, moveY).normalized;
        Vector2 newPos = Rigidbody2D.position + Movement * CurrentSpeed * Time.fixedDeltaTime;
        
        //Clamp
        newPos.x = Mathf.Clamp(newPos.x, minX, maxX);
        newPos.y = Mathf.Clamp(newPos.y, minY, maxY);

        Rigidbody2D.MovePosition(newPos);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (MenuManage.isPaused == false)
            {
                if (Stamina >= 10)
                {
                    Stamina -= 10;
                    ShootBullet();
                }
                else
                {
                    Debug.Log("No Stamina!!!!");
                }
            } 
        }


        if (Input.GetKey(KeyCode.LeftShift) && Stamina >= 0)
        {
            CurrentSpeed = OriginalSpeed * 3;
            isrunning = true;
            ruduceStamina();
        }
        else
        {
            CurrentSpeed = OriginalSpeed;
            isrunning = false;
            recoverStamina();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log(Stamina + "    " + CurrentSpeed);
        }

        StaminaText.text = "Stamina: " + Stamina.ToString("F0");

        ScoreText.text = "Score: " + Bullet.Score.ToString("F0");

        HPText.text = "HP: " + HP.ToString("F0");

        if (HP == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void ShootBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation);
        Destroy(bullet, 3f);
    }

    void TakeDamage()
    {
        HP -= 1;
    }
    void ruduceStamina()
    {
        if (isrunning)
        {
            Stamina -= 50 * Time.deltaTime;
        }
    }
    void recoverStamina()
    {
        if (!isrunning)
        {
            if (Stamina < 100)
            {
                Stamina += 10 * Time.deltaTime;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy02Bullet"))
        {
            Destroy(collision.gameObject);
            TakeDamage();
        }
    }
}
