using UnityEngine;
using UnityEngine.SceneManagement; // it is used to load or just work with multiple scenes

public class Menu : MonoBehaviour
{
    public void StartGame () 
    {
        Debug.Log("Starrting the game");
        Debug.Log("Loading new level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

