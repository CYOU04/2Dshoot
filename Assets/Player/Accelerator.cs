using UnityEngine;

public class Accelerator : MonoBehaviour
{
    public GameObject Accelerate;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.isrunning == true)
        {
            Accelerate.SetActive(true);
        }
        else
        {
            Accelerate.SetActive(false);
        }
    }
}
