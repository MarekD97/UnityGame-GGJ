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
        newPosition = new Vector3(-10f, 0, 0);
        newOrientation = Quaternion.AngleAxis(90, Vector3.up);
        idNumerator = 0;
    }

    // Update is called once per frame
    void Update()
    {
        counter -= 1 * Time.deltaTime;
        if(counter <= 0)
        {
            character = RandomCharacter();
            idNumerator++;
            counter = delayTime;
        }
    }

    GameObject RandomCharacter()
    {
        GameObject randomCharacter = Instantiate(character, newPosition, newOrientation);
        randomCharacter.name = "Character" + idNumerator;
        int random = Mathf.FloorToInt(Random.Range(0, 4));
        Debug.Log(random);
        randomCharacter.transform.Find("characterMedium").GetComponent<SkinnedMeshRenderer>().material = materials[random];

        return randomCharacter;
    }
}
