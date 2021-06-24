using UnityEngine;
using UnityEngine.SceneManagement; // it is used to load or just work with multiple scenes

public class BackToMenu : MonoBehaviour
{
    public void BackToM () 
    {
        Debug.Log("Back to Menu");
        SceneManager.LoadScene(0);
    }
}

