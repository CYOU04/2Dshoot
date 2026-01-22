using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
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
        SceneManager.LoadScene("StartUI");

        PlayerController.HP = 3;
        Bullet.Score = 0;
        PlayerController.Stamina = 100;

        Debug.Log("Title");
    }
}
