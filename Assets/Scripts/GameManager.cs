//using System.Collections; // we don't need this
//using System.Collections.Generic; // and this
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float delayTime = 1f;
    public GameObject compUI;
    
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
    
    public void EndGame () // ends game
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("THE END"); // debug
            //Restart(); // call method Restart
            Invoke("Restart", delayTime); // Invoke needs two parameters Invoke("Name of function that we want to call", delay time);
        }
    }
    
    void Restart () // resarts current level
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // you can type a name o the scene like "Level01". SceneManager.GetActiveScene().name returns the name of current scene 
        // SceneManager.LoadScene loads the scene.
    }
    
    public void CompleteLevel ()
    {
        //Debug.Log("KO");
        compUI.SetActive(true);
    }
}

