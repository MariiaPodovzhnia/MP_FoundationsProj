using UnityEngine;

public class removekey : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("CLICK WORKS!");

        ClickToDestroy key = GetComponentInParent<ClickToDestroy>();

        if (key != null)
        {
            Debug.Log("PARENT FOUND!");
            key.RemoveKey();
        }
        else
        {
            Debug.Log("PARENT NOT FOUND!");
        }
    }
}