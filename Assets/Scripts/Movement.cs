using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 axis;
    // GroundCheck groundCheck;
    void Start()
    {
        // groundCheck = FindObjectOfType<GroundCheck>();
        axis = new Vector3(speed,0,0);
    }

    // Update is called once per frame
    void Update()
    {  
        // if(groundCheck.isGrounded == false) {
        //     axis = new Vector3(0,0,0);
        // }else{
        //     axis = new Vector3(speed,0,0);
        // }
        transform.position += Time.deltaTime * axis;
    }
    
}
