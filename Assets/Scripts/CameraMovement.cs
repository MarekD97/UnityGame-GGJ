using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float horizontalSpeed = 1.0F;
    public float verticalSpeed = 1.0F;
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            float h = horizontalSpeed * Input.GetAxis("Mouse X");
            float v = verticalSpeed * Input.GetAxis("Mouse Y");
            transform.Translate(transform.worldToLocalMatrix * new Vector3(-h, 0, -v));
        }
        
    }

}
