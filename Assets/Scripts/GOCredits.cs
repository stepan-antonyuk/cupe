using UnityEngine;
using UnityEngine.SceneManagement; // it is used to load or just work with multiple scenes

public class GOCredits : MonoBehaviour
{
    public void GoToCredits () 
    {
        Debug.Log("Loading Credits");
        SceneManager.LoadScene(4);
    }
}

