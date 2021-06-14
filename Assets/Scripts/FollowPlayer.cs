/*
using System.Collections;   // we don't need this
using System.Collections.Generic; // and this
*/

using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player; // stores Transform parametters from Unity Object that is assigned to this parammeter
    public Vector3 offset; // Vector3 stores 3 numbers floats, I assume that Vector2 stores 2 floats

    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }
    */

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position); // prints in console
        // transform wiht not capital t refers to transfrom of our curretn object, the objecy on what this script is sitting on
        transform.position = player.position + offset; // it works because (x1, y1, z1) + (x2, y2, z2) = (x1 + x2, y1 + y2, z1 + z2)
    }
}

