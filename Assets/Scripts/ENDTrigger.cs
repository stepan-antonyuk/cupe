//using System.Collections; // we don't need this 
//using System.Collections.Generic; // and this
using UnityEngine;

public class ENDTrigger : MonoBehaviour
{
    
    public GameManager gameManager; // reference to GameManager object
    
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
    
    void OnTriggerEnter ()
    {
        Debug.Log("Loading new level");
        gameManager.CompleteLevel();
    }        
}

