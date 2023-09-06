using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Here are all the variables for our PlayerController Class:

    //Movement:
    [SerializeField]
    private float speed = 5.0f; //A speed variable that allows us to change the player speed

    [SerializeField]
    private float jumpForce = 3.0f; //A jump force variable that allows us to change the player jump strength

    [Space]
    //Keybinds:
    [SerializeField]
    private KeyCode jump = KeyCode.Space;
    [SerializeField]
    private KeyCode moveForward = KeyCode.W;
    [SerializeField]
    private KeyCode moveBackward = KeyCode.S;
    [SerializeField]
    private KeyCode moveLeft = KeyCode.A;
    [SerializeField]
    private KeyCode moveRight = KeyCode.D;



    void Start()
    {
        Debug.Log("Game has begun!");
    }

    void Update()
    {
        if (Input.GetKey(moveForward))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
