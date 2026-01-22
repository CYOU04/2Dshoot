using UnityEngine;

public class SpawnBlock : MonoBehaviour
{
    [SerializeField] GameObject blockPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FillBlock(10, 10, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FillBlock(float w, float h, float size)
    {
        var x0 = -w/2 + size/2;
        var y0 = -h/2 + size/2;

        for (var y = y0; y < y0 + h; y += size)
        {
            for (var x = x0; x < x0 +w; x += size)
            {
                var go = Instantiate(blockPrefab);
                go.transform.position = new Vector3(x, y, 0);
                go.transform.localScale = Vector3.one * size;
            }
        }
    }
}
