using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        
        SceneManager.LoadScene("Dialogue");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Игра закрыта");
    }
}