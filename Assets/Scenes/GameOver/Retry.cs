using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonClick()
    {
        SceneManager.LoadScene("Stage01");

        PlayerController.HP = 3;
        Bullet.Score = 0;
        PlayerController.Stamina = 100;

        Time.timeScale = 1;
        MenuManage.isPaused = false;

        Debug.Log("Retry");
    }
}
