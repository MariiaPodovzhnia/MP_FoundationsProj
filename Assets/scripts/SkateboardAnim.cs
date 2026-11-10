using UnityEngine;

public class SkateboardController : MonoBehaviour
{
    private Animator animator;
    private bool isClickedState = false;

    void Start()
    {
        
        animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        
        isClickedState = !isClickedState;

        
        if (animator != null)
        {
            animator.SetBool("IsClicked", isClickedState);
        }
   
    
    isClickedState = !isClickedState;
    if (animator != null)
    {
        animator.SetBool("IsClicked", isClickedState);
    }
}
}