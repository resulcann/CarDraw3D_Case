using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTouch : MonoBehaviour
{
    public Camera cam;

    private void Update()
    {
        //Make a plane to hit with ray to 
        if (Input.GetMouseButton(0) && DrawOnCanvas.touchOnUIElement)
        {
            Plane plane = new Plane(cam.transform.forward * -1, transform.position);

            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            float rayDistance;

            if(plane.Raycast(ray, out rayDistance))
            {
                transform.position = ray.GetPoint(rayDistance);
            }

            StartCoroutine(EmitAfterPositionTranslationFrame());
        }
        else
        {
            GetComponent<TrailRenderer>().emitting = false;
            GetComponent<TrailRenderer>().time = 0;
        }
        
    }

    //This is done to prevent the instant line generated when an emitting trail is relocated
    IEnumerator EmitAfterPositionTranslationFrame()
    {
        yield return new WaitForEndOfFrame();

        GetComponent<TrailRenderer>().emitting = true;
        GetComponent<TrailRenderer>().time = 100f;
    }
}