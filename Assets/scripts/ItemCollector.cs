using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    [Header("Collection Settings")]
    public int totalItems = 3;
    private int currentItems = 0;

    [Header("UI Elements")]
    public TextMeshProUGUI counterText; // Counter text at the top of the screen

    private void Start()
    {
        // Update the counter text when the game starts
        UpdateCounterUI();
    }

    public void CollectItem()
    {
        currentItems++;
        UpdateCounterUI(); // Update numbers on the screen

        Debug.Log("Items collected: " + currentItems + " of " + totalItems);

        // If all items are collected, you can add some logic here if needed, 
        // but the game will NOT pause or stop.
        if (currentItems >= totalItems)
        {
            Debug.Log("All items collected!");
        }
    }

    void UpdateCounterUI()
    {
        if (counterText != null)
        {
            counterText.text = "Collected: " + currentItems + " / " + totalItems;
        }
    }
    // Метод проверяет, собраны ли все предметы
public bool HasCollectedAll()
{
    return currentItems >= totalItems;
}
}