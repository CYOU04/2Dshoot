using UnityEngine;

public class SpawnEnemy01 : MonoBehaviour
{
    public GameObject Enemy01Prefab;

    void Start()
    {
        InvokeRepeating("GenEnemy01", 2, Random.Range(1f, 3f));
    }
    void GenEnemy01()
    {
        Instantiate (Enemy01Prefab, new Vector3 (8, -2.5f + 5 * Random.value, 0), Quaternion.identity);
    }
    void Update()
    {
        
    }
}
