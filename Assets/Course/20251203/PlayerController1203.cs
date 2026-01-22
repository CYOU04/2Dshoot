using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController1203 : MonoBehaviour
{
    float rotSpeed = 360f;
    float speed = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxisRaw("Horizontal");
        var v = Input.GetAxisRaw("Vertical");

        var angle = transform.rotation.eulerAngles;
        angle.z -= h * rotSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(angle);

        transform.Translate(Vector2.up * v * Time.deltaTime * speed);
    }
}
