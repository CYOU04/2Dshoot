using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStart : MonoBehaviour
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
        PlayerController.HP = 3;
        Bullet.Score = 0;
        PlayerController.Stamina = 100;

        Time.timeScale = 1;
        MenuManage.isPaused = false;

        Debug.Log("Game Start");
        SceneManager.LoadScene("Stage01");
    }
}