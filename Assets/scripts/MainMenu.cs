using UnityEngine;

public class MainMenu : MonoBehaviour
{
        public GameObject menuPanel;

    void Start()
    {
       
        Time.timeScale = 1f;
    }

    public void StartGame()
    {
        
        if (menuPanel != null)
        {
            menuPanel.SetActive(false);
        }

       
    }
}