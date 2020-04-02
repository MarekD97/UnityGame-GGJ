using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    public Transform moveThis;
    //the layers the ray can hit
    public LayerMask hitLayers;

    void OnMouseDown()
    {
        moveThis = gameObject.transform;
        hitLayers = LayerMask.GetMask("Plane");
    }
    void OnMouseDrag()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers))
        {
            moveThis.transform.position = hit.point;
        }
    }
}
