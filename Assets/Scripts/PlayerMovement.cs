using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float theENDy = -1f;
    
    // f on the end of the number is sjows that this number is float, Unity sometimes complaint about float number without f on the end 
    public float forwardForce = 2000f; // forward speed of player
    public float horizontalForce = 500f; // horizontal speed of player if a or d is pressed
    
    /*
    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity = true; //turns off and on the graviy
        rb.AddForce(0, 200, 500); // apply force on the objetc (x, y, z)
    }
    */
    /*
    float Normal = 0f;
    public float Max = 75f;
    public Transform MainCamera;
    public float step = 2f;
    public float BackStep = 1f;
    */
    // Update is called once per frame
    void FixedUpdate() // FixedUpdate works with forces
    {   
        //Debug.Log(MainCamera.rotation.z);
        //Debug.Log(MainCamera.rotation.z < Max);
    
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // forth pramether is how force is applayed, ForceMode.VelocityChange is directlly effects velocity and ignors its mass
            /*
            if(MainCamera.rotation.z < Max)
            {
                MainCamera.rotation = Quaternion.Euler(0, 0, MainCamera.rotation.z + step);
            }
            */
        }
        /*
        else
        {
            if(MainCamera.rotation.z > Normal)
            {
                MainCamera.rotation = Quaternion.Euler(0, 0, MainCamera.rotation.z - BackStep);
            }
        }
        */
        
        if (Input.GetKey("a"))
        {
            rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // same here
            /*
            if(MainCamera.rotation.z > -Max)
            {
                MainCamera.rotation = Quaternion.Euler(0, 0, MainCamera.rotation.z - step);
            }
            */
        }
        /*
        else
        {
            if(MainCamera.rotation.z < Normal)
            {
                MainCamera.rotation = Quaternion.Euler(0, 0, MainCamera.rotation.z + BackStep);
            }
        }
        */
        
        if (rb.position.y < theENDy)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

