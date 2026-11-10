using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    [Header("Win Settings")]
    public int requiredItems = 3;
    
    [Header("UI")]
    public GameObject winPanel; 

    private void OnMouseDown()
    {
        ItemCollector collector = FindFirstObjectByType<ItemCollector>();

        if (collector != null)
        {
            // check if the player has collected all required items
            if (collector.HasCollectedAll())
            {
                Debug.Log("Door opened! You won the game!");
                WinGame();
            }
            else
            {
                Debug.Log("You need to collect all items first! Not enough items.");
            }
        }
        else
        {
            Debug.LogWarning("ItemCollector (GameManager) not found on the scene!");
        }
    }

    private void WinGame()
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