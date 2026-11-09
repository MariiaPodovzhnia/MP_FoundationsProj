

using UnityEngine;

public class ClickAnim : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

        if (animator == null)
        {
            animator = GetComponentInChildren<Animator>();
        }
    }

    void OnMouseDown()
    {
        if (animator != null)
        {
            animator.SetBool("IsClicked", true);
        }
        else
        {
            Debug.LogError("Animator not found!");
        }
    }
}
