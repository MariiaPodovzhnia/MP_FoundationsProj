using UnityEngine;

public class MenuManager : MonoBehaviour
{
    
    public GameObject menuPanel;

    public void OnStartButtonClicked()
    {
    

        
        if (menuPanel != null)
        {
            menuPanel.SetActive(false);
        }
        else
        {
            
            gameObject.SetActive(false);
        }

        
        Time.timeScale = 1f;
    }
}