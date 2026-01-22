using UnityEngine;

public class SpawnStaminaRecover : MonoBehaviour
{
    public GameObject StaminaRecover;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("GenStanimaRecover", 10, Random.Range(10f, 15f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GenStanimaRecover()
    {
        Instantiate(StaminaRecover, new Vector3(8, -2.5f + 5 * Random.value, 0), Quaternion.identity);
    }
}
