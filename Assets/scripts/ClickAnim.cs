using UnityEngine;


public class ClickAnim : MonoBehaviour
{
    public Animator thisAnimator; 

    void Start()
    {
        thisAnimator = gameObject.GetComponent<Animator>(); 
    }

    void OnMouseDown()
    {
        thisAnimator.SetBool("IsClicked", true);
        Debug.Log("Object clicked, animation started");
    }
}
