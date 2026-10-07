using UnityEngine;
//This script is to Destroy a Game Object using the Spacebar
public class NewMonoBehaviourScript : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}
