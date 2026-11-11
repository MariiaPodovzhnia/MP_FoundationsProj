using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class UIFunctions : MonoBehaviour
{
    public string sceneName; 

    public GameObject objectToToggle;
    public GameObject UIMenu;

    public GameObject dialogueBox;        
    public TextMeshProUGUI dialogueText;  
    public string[] dialogueLines;        
    int currentDialogueIndex = 0;

 void Start()
{
    if (dialogueLines != null && dialogueLines.Length > 0 && dialogueText != null)
    {
        dialogueText.text = dialogueLines[0];
    }
}

    void Update()
    {
        PressKeyToSetActive();
    }

    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
         // loads scene by string name
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
        // loads next scene in build index
    }

    public void QuitGameBtn()
    {
        Application.Quit();
        Debug.Log("Application has Quit. This will only quit when running Build");
    }

    public void ActivateObjectBtn()
    {
        objectToToggle.SetActive(true);
    }

    public void PressKeyToSetActive()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            UIMenu.SetActive(true);
        }
    }

    
    public void NextDialogueLine()
    {
        currentDialogueIndex = currentDialogueIndex + 1;

        if (currentDialogueIndex < dialogueLines.Length)
        {
            dialogueText.text = dialogueLines[currentDialogueIndex];
        }
        else
        {
            dialogueBox.SetActive(false); // hides dialogue box when finished
            Debug.Log("Dialogue hint finished, closing box");
        }
    }
}