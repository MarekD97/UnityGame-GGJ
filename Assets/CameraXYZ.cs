using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraXYZ : MonoBehaviour
{
    private float ScrollSpeed = 10f;
    int width;
    int height;
    float p;
    Vector3 pos;
    public float speed = 6.0f;
    private Vector3 normalizeDirection;

    void Start()
    {
        width = Screen.width;
        height = Screen.height;


    }

    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            transform.position += ScrollSpeed * new Vector3(0, -Input.GetAxis("Mouse ScrollWheel"), Input.GetAxis("Mouse ScrollWheel"));
        }
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            pos = Input.mousePosition;
            pos.y = pos.y - (float)height / 2.0f;
            pos.z = pos.y;
            p = pos.z;
            pos.y = 0.0f;
            pos = Camera.main.ScreenToWorldPoint(pos);

            if (p < 0)
            {
                pos.x = (-1) * pos.x;
            }

            normalizeDirection = (pos - transform.position).normalized;

            normalizeDirection.y = 0.0000f;
            transform.Translate(normalizeDirection * speed * Time.deltaTime);
        }

    }

}
