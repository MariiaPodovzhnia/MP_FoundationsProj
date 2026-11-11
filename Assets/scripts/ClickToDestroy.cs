using UnityEngine;


public class ClickToDestroy : MonoBehaviour
{
    public GameObject myGameManager; 
    ItemCollector myCollectorScript; 

    void Start()
    {
        
        if (myGameManager != null)
        {
            myCollectorScript = myGameManager.GetComponent<ItemCollector>();
        }
    }

   
    public void RemoveKey()
    {
        Debug.Log("Item removed: " + gameObject.name);

        if (myCollectorScript != null)
        {
            myCollectorScript.CollectItem();
        }

        GameObject.Destroy(gameObject); 
    }

  
    void OnMouseDown()
    {
        RemoveKey();
    }
}