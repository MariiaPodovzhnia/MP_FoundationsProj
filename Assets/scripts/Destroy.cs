using UnityEngine;

public class Destroy: MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("Key clicked!");

        Transform parent = transform.parent;

        if (parent != null)
        {
            Destroy(parent.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}