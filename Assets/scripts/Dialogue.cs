using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Dialogue : MonoBehaviour
{
    [Header("UI elements")]
    public TextMeshProUGUI dialogueText; 
    public TextMeshProUGUI buttonText;   

    [Header("Scene Settings")]
    public string gameSceneName = "01_MainScene_SkatePark"; 

    [Header("Lines")]
    [TextArea(2, 5)]
    public string[] dialogueLines;
    private int currentDialogueIndex = 0;

    void Start()
    {
        
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        if (dialogueLines.Length > 0 && dialogueText != null)
        {
            dialogueText.text = dialogueLines[0];
        }
    }

    public void OnNextButtonClick()
    {
        currentDialogueIndex++;

        
        if (currentDialogueIndex < dialogueLines.Length)
        {
            dialogueText.text = dialogueLines[currentDialogueIndex];

            
            if (currentDialogueIndex == dialogueLines.Length - 1 && buttonText != null)
            {
                buttonText.text = "Play!";
            }
        }
        else
        {
            
            SceneManager.LoadScene(gameSceneName);
        }
    }
}