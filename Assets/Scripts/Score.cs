//using System.Collections; // we don't need this 
//using System.Collections.Generic; // and this
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }
    */

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position.z);  
        scoreText.text = player.position.z.ToString("0"); // scoreText.text we can change text in UI. ToString("0") writes only whole part without decimals
    }
}

