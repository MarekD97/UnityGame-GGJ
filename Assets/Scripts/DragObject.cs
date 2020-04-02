using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    //the layers the ray can hit
    public LayerMask hitLayers;

    void OnMouseDown()
    {
    }
    void OnMouseUp()
    {

    }
    void OnMouseDrag()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers))
        {
            gameObject.transform.position = hit.point;
        }
    }
}
