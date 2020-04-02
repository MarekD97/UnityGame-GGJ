using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAI : MonoBehaviour
{
    Vector3 endPoint;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        endPoint = RandomPosition();
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((int)gameObject.transform.position.x == (int)endPoint.x && (int)gameObject.transform.position.z == (int)endPoint.z)
            endPoint = RandomPosition();
        transform.position = Vector3.MoveTowards(gameObject.transform.position, endPoint, 0.1f);
        //Vector3 direction = Vector3.up;
        //float angle;
        //Quaternion.LookRotation(endPoint, gameObject.transform.position).ToAngleAxis(out angle, out direction);
        transform.forward = endPoint;

        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        if (Vector3.Distance(gameObject.transform.position, endPoint) > 0.8)
        {
            anim.SetTrigger("isRun");
        }
        else
        {
            anim.ResetTrigger("isRun");
        }
    }

    Vector3 RandomPosition()
    {
        float randomPositionX, randomPositionZ;
        randomPositionX = Random.Range(-10f, 10f);
        randomPositionZ = Random.Range(-10f, 10f);

        return new Vector3(randomPositionX, 0, randomPositionZ);

    }
}
