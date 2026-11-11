using UnityEngine;


public class DoorInteraction : MonoBehaviour
{
    public GameObject myGameManager; 
    ItemCollector myCollectorScript;

    public int requiredItems = 3; 
    public GameObject winPanel;   

    void Start()
    {
        
        if (myGameManager != null)
        {
            myCollectorScript = myGameManager.GetComponent<ItemCollector>();
        }
    }

    void OnMouseDown()
    {
        if (myCollectorScript != null)
        {
            
            if (myCollectorScript.HasCollectedAll())
            {
                Debug.Log("Door opened! You won the game!");
                WinGame();
            }
            else
            {
                Debug.Log("You need to collect all items first! Not enough items.");
            }
        }
    }

    void WinGame()
    {
        if (winPanel != null)
        {
            winPanel.SetActive(true); 
        }

        Time.timeScale = 0f; 
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}