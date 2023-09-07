using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Here are all the variables for our PlayerController Class:

    //Movement:
    [SerializeField]
    private float walkingSpeed = 1.5f; //A speed variable that allows us to change the player's walking speed
    [SerializeField]
    private float sprintSpeed = 3f; //A speed variable that allows us to change the players spriting speed
    [SerializeField]
    public float moveSpeed = 5f;  //A move variable that allows us to change the players speed in relation to the camera POV
    [SerializeField]
    private float strafeSpeed = 1f; //A speed variable that allows us to change the player's side movement
    [SerializeField]
    private float jumpForce = 3.0f; //A jump force variable that allows us to change the player's jump strength

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
    [SerializeField]
    private KeyCode sprintKey = KeyCode.LeftShift;

    //States:

    void Start()
    {
        //Making sure the game starts
        Debug.Log("Game has begun!");
    }

    void Update()
    {
        PlayerMovement();
    }

    //This is the player movement method. PLEASE DON'T TOUCH!!!!!!!!!!!
    void PlayerMovement()
    {
        //Move Forward:
        if (Input.GetKey(moveForward))
        {
            MovementFunctions.MoveForward(transform, walkingSpeed);
        }

        //Move Backward:
        if (Input.GetKey(moveBackward))
        {
            MovementFunctions.MoveBackward(transform, walkingSpeed);
        }

        //Move Left:
        if (Input.GetKey(moveLeft))
        {
            MovementFunctions.MoveLeft(transform, strafeSpeed);
        }

        //Move Right:
        if (Input.GetKey(moveRight))
        {
            MovementFunctions.MoveRight(transform, strafeSpeed);
        }

        //Sprint Forward:
        if (Input.GetKey(moveForward) && Input.GetKey(sprintKey))
        {
            MovementFunctions.SprintForward(transform, sprintSpeed);
        }
    }
}
