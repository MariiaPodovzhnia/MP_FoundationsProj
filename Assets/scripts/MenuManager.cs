using UnityEngine;


public class MenuManager : MonoBehaviour
{
    public GameObject menuPanel; // UI panel to turn off

    // This method is called from resume or start button
    public void OnStartButtonClicked()
    {
        Debug.Log("Closing menu panel and resuming game");

        if (menuPanel != null)
        {
            menuPanel.SetActive(false); // hides menu panel
        }

        Time.timeScale = 1f; // unpauses the game time
    }
}