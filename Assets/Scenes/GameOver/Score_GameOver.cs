using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score_GameOver : MonoBehaviour
{
    public Text ScoreText_GameOver;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText_GameOver.text = "Score: " + Bullet.Score.ToString("F0");
    }
}
