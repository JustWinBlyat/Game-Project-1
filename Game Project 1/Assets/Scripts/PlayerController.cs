using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Here are all the variables for our PlayerController Class:

    //Movement:
    [SerializeField]
    private float movementSpeed = 3f; //A speed variable that allows us to change the player speed
    [SerializeField]
    private float strafeSpeed = 1.5f; //A speed variable that allows us to change the player side movement
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
        playerMovement();
    }


    //This is the player movement method. PLEASE DON'T TOUCH!!!!!!!!!!!
    void playerMovement()
    {
        //Move Forward:
        if (Input.GetKey(moveForward))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
        }

        //Move Backward:
        if (Input.GetKey(moveBackward))
        {
            transform.Translate(Vector3.back * Time.deltaTime * movementSpeed);
        }

        //Move Left:
        if (Input.GetKey(moveLeft))
        {
            transform.Translate(Vector3.left * Time.deltaTime * strafeSpeed);
        }

        //Move Right:
        if (Input.GetKey(moveRight))
        {
            transform.Translate(Vector3.right * Time.deltaTime * strafeSpeed);
        }
    }
}
