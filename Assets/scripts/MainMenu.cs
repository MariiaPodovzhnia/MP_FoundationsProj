using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string firstSceneName = "Dialogue";

    public void StartGame()
    {
        SceneManager.LoadScene(firstSceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Application has Quit. This will only quit when running Build");
    }
}