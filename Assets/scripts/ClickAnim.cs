using UnityEngine;

public class ClickAnim : MonoBehaviour
{
    Animator animator;
    
    // This script is click to trigger an animation on the object the script is attached to
    void Start()
    {
      animator = GetComponent<Animator>();  
    }

    
    void OnMouseDown()
    {
        animator.SetBool("IsClicked", true);
    }
}
