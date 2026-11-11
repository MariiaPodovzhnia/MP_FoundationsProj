using UnityEngine;


public class removekey : MonoBehaviour
{
    public ClickToDestroy keyScript; // reference to main destroy script

    void Start()
    {
        // automatically finds ClickToDestroy 
        if (keyScript == null)
        {
            keyScript = GetComponentInParent<ClickToDestroy>();
        }
    }

    void OnMouseDown()
    {
        Debug.Log("Child key clicked: " + gameObject.name);

        if (keyScript != null)
        {
            keyScript.RemoveKey();
        }
    }
}