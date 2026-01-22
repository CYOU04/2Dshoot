using UnityEngine;
using UnityEngine.UIElements;

public class AccleratorRotation : MonoBehaviour
{
    Transform player;

    public Transform exhaustTransform;
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        if (player == null)
        {
            Destroy(gameObject);
            return;
        }

        float moveY = Input.GetAxisRaw("Vertical");
        float Rotation = 0f;

        if (moveY > 0)
        {
            Rotation = 45f;
        }
        else if (moveY < 0)
        {
            Rotation = -45f;
        }
        else
        {
            Rotation = 0f;
        }

        Quaternion targetRotation = Quaternion.Euler(0, 0, Rotation);
        exhaustTransform.rotation = Quaternion.Lerp(exhaustTransform.rotation, targetRotation, Time.deltaTime * 10f);
    }
}