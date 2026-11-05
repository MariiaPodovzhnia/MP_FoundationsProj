using UnityEngine;

public class ClickToDestroy : MonoBehaviour
{
    public void RemoveKey()
    {
        Destroy(gameObject);
    }
}