using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [Header("Панель меню, которую нужно скрыть")]
    public GameObject menuPanel;

    public void OnStartButtonClicked()
    {
        Debug.Log("Кнопка Start нажата, запускаем игру!");

        // 1. Выключаем панель меню
        if (menuPanel != null)
        {
            menuPanel.SetActive(false);
        }
        else
        {
            // Если забыли перетащить панель в поле, выключим объект, на котором висит скрипт (например, сам Canvas)
            gameObject.SetActive(false);
        }

        // 2. Возвращаем нормальную скорость времени (на случай, если игра была на паузе)
        Time.timeScale = 1f;
    }
}