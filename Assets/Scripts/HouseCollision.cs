using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.name != "Ground")
        {
            Destroy(collision.collider.gameObject);
            Debug.Log("Usunięto");
        }
    }
}
