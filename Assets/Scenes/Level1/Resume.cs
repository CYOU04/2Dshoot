using UnityEngine;

public class Resume : MonoBehaviour
{
    public MenuManage MenuManage;
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
        MenuManage.Resume();
        Debug.Log("Resume");
    }
}
