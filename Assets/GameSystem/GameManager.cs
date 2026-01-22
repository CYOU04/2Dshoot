using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Game Level")]
    private float GlobalSpeedMultiplier = 1f;
    private float DifficultyIncreaseRate = 0.1f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        GlobalSpeedMultiplier += DifficultyIncreaseRate * Time.deltaTime; 
    }

    public float GetCurrentSpeed(float OriginalSpeed)
    {
        return OriginalSpeed * GlobalSpeedMultiplier;
    }
}
