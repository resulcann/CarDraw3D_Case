using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public float distanceGround = 1.25f;
    public bool isGrounded = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(Physics.Raycast(transform.position, Vector3.down, distanceGround));
        if(Physics.Raycast(transform.position, Vector3.down, distanceGround))
        {
            isGrounded = true;
        }
        else{
            isGrounded = false;
        }





        // if(!Physics.Raycast(transform.position, -Vector3.up, distanceGround + 0.1f))
        // {
        //     isGrounded = false;
        //     print("false");
        // }else{
        //     isGrounded = true;
        //     print("true");
        // }
    }
}
