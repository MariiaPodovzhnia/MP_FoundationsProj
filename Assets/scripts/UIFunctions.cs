using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIFunctions : MonoBehaviour
{
    [Header("Scene Settings")]
    public string sceneName;

    [Header("Toggle & Menu")]
    public GameObject objectToToggle;
    public GameObject UIMenu;

    [Header("Dialogue / Hints")]
    public GameObject dialogueBox;      
    public TextMeshProUGUI dialogueText; 
    [TextArea(2, 5)]
    public string[] dialogueLines;       
    private int currentDialogueIndex = 0;

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
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGameBtn()
    {
        Application.Quit();
        Debug.Log("Application has Quit. This will only quit when running Build");
    }

    public void ActivateObjectBtn()
    {
        if (objectToToggle != null)
        {
            objectToToggle.SetActive(true);
        }
    }

    public void PressKeyToSetActive()
    {
        if (Input.GetKeyDown(KeyCode.Q) && UIMenu != null)
        {
            UIMenu.SetActive(true);
        }
    }

    // Next Method
    public void NextDialogueLine()
    {
        currentDialogueIndex++;

        // If there are more lines to show, update the dialogue text; otherwise, hide the dialogue box
        if (currentDialogueIndex < dialogueLines.Length)
        {
            if (dialogueText != null)
            {
                dialogueText.text = dialogueLines[currentDialogueIndex];
            }
        }
        else
        {
            // When all lines are shown, hide the dialogue box
            if (dialogueBox != null)
            {
                dialogueBox.SetActive(false);
            }
        }
    }
}