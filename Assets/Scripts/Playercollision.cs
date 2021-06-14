//using System.Collections; // we don't need this
//using System.Collections.Generic; // and this

using UnityEngine;

public class Playercollision : MonoBehaviour
{

    public PlayerMovement movement;

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
    
    void OnCollisionEnter (Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name); // collisionInfo.collider is object that we collided with, collisionInfo.collider.name is the name of the object that we collided with
        if (collisionInfo.collider.tag == "Obstacle") // collisionInfo.collider.tag is cheking for the tag of the collider
        {
            Debug.Log("We hit an obstacle!");
            movement.enabled = false; // turn of the PlayerMovemnet script
            
            Debug.Log("Reloading");
            FindObjectOfType<GameManager>().EndGame(); // FindObjectOfType<> is simmillar to GetComponent<>
        }
    }
}

