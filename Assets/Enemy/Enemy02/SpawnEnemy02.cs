using UnityEngine;

public class SpawnEnemy02 : MonoBehaviour
{
    public GameObject Enemy02Prefab;
    void Start()
    {
        InvokeRepeating("GenEnemy02", 2, 5);
    }
    void GenEnemy02()
    {
        Vector2 SpawnPosition = new Vector2(8, -2.5f + 5 * Random.value);

        float CheckRadius = 0.7f;
        Collider2D hit = Physics2D.OverlapCircle(SpawnPosition, CheckRadius);
        if (hit == null)
        {
            Instantiate(Enemy02Prefab, SpawnPosition, Quaternion.identity);
        }
        else
        {
            Debug.Log("Spawn skipped to avoid overlap");
        }
        //Instantiate(Enemy02Prefab, new Vector3(8, -2.5f + 5 * Random.value, 0), Quaternion.identity);
    }
    void Update()
    {
        
    }
}