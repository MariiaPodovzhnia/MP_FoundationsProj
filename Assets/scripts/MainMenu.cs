using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Переменная для панели меню, которую нужно скрыть при старте
    public GameObject menuPanel;

    void Start()
    {
        // Убеждаемся, что игра идет на нормальной скорости
        Time.timeScale = 1f;
    }

    public void StartGame()
    {
        // Выключаем объект панели меню (картинка, текст и кнопка пропадут)
        if (menuPanel != null)
        {
            menuPanel.SetActive(false);
        }

        // Здесь также можно включить управление игрока, если оно было отключено
    }
}