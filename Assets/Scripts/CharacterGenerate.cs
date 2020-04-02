using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGenerate : MonoBehaviour
{
    GameObject character;
    Vector3 newPosition;
    Quaternion newOrientation;
    private float counter;
    private float delayTime;
    int idNumerator;
    public Material[] materials;
    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("CharacterMedium");
        delayTime = 5;
        counter = delayTime;
        idNumerator = 0;
    }

    // Update is called once per frame
    void Update()
    {
        counter -= 1 * Time.deltaTime;
        if(counter <= 0)
        {
            RandomCharacter();
            idNumerator++;
            counter = delayTime;
        }
    }

    void RandomCharacter()
    {
        GameObject randomCharacter = Instantiate(character, RandomPosition(), RandomOrientation());
        randomCharacter.name = "Character" + idNumerator;
        int random = Random.Range(0, 4);
        randomCharacter.transform.Find("characterMedium").GetComponent<SkinnedMeshRenderer>().material = materials[random];
        
    }

    Vector3 RandomPosition()
    {
        float randomPositionX, randomPositionZ;
        randomPositionX = Random.Range(-10f, 10f);
        randomPositionZ = Random.Range(-10f, 10f);

        return new Vector3(randomPositionX, 0, randomPositionZ);
    
    }

    Quaternion RandomOrientation()
    {
        return Quaternion.AngleAxis(Random.Range(0, 360), Vector3.up);
    }
}
