using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{
    CharacterController character;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(inputX, 0f,inputY);
        character.Move(movement * Time.deltaTime);
        
    }
}
