using UnityEngine;

public class SkateboardController : MonoBehaviour
{
    private Animator animator;
    private bool isClickedState = false;

    void Start()
    {
        // Получаем компонент Animator, который находится на этом же объекте
        animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        // Инвертируем состояние (при каждом клике оно меняется: true -> false -> true)
        isClickedState = !isClickedState;

        // Передаем значение в Animator в параметр "IsClicked"
        if (animator != null)
        {
            animator.SetBool("IsClicked", isClickedState);
        }
   
    Debug.Log("Клик по скейтборду зарегистрирован!");
    isClickedState = !isClickedState;
    if (animator != null)
    {
        animator.SetBool("IsClicked", isClickedState);
    }
}
}