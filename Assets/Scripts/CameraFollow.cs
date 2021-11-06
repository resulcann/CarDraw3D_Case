using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform car;

    private float carLastPositionX;

    void Start()
    {
        //Arabanın ilk X konumunu saklıyorum.
        carLastPositionX = car.position.x;
    }


    void Update()
    {
        //Arabanın konumundaki değişikliği kameranın konumuna uygulayarak arabayı X ekseninde takip ediyorum.

        float playerPositionChangeOnThisFrame = car.position.x - carLastPositionX;
        carLastPositionX = car.position.x;

        transform.position += new Vector3(playerPositionChangeOnThisFrame, 0, 0);

    }
}
