using UnityEngine;

public class ClickToDestroy : MonoBehaviour
{
    public void RemoveKey()
    {
        
        ItemCollector collector = FindFirstObjectByType<ItemCollector>();
        if (collector != null)
        {
            collector.CollectItem();
        }

        
        Destroy(gameObject);
    }
}