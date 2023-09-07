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
    [SerializeField]
    private KeyCode lockState = KeyCode.Escape;

    [Space]

    //States:
    [SerializeField]
    private bool isCursorLocked = true; //A boolean that tracks the mouse cursor state

    void Start()
    {
        //Making sure the game starts
        Debug.Log("Game has begun!");
    }

    void Update()
    {
        PlayerMovement();
        MouseCursorState();
    }

    //This is the player movement method. PLEASE DON'T TOUCH!!!!!!!!!!!
    void PlayerMovement()
    {
        //Move Forward:
        if (Input.GetKey(moveForward))
        {
            MoveForward();
        }

        //Move Backward:
        if (Input.GetKey(moveBackward))
        {
            MoveBackward();
        }

        //Move Left:
        if (Input.GetKey(moveLeft))
        {
            MoveLeft();
        }

        //Move Right:
        if (Input.GetKey(moveRight))
        {
            MoveRight();
        }

        //Sprint Forward:
        if (Input.GetKey(moveForward) && Input.GetKey(sprintKey))
        {
            SprintForward();
        }
    }

    

    //This is a cursor function that controls the cursor visibility during gameplay
    void MouseCursorState()
    {
        if (Input.GetKey(lockState))
        {
            isCursorLocked = !isCursorLocked;

            if (isCursorLocked)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }

            else
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }

    /************************
    Movement Functions Here:
    - Forward
    - Backward
    - Side (Left/Right)
    - Sprint
    - Jump
    *************************/

    void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * walkingSpeed);
    }

    void MoveBackward()
    {
        transform.Translate(Vector3.back * Time.deltaTime * walkingSpeed);
    }

    void MoveLeft()
    {
        transform.Translate(Vector3.left * Time.deltaTime * strafeSpeed);
    }

    void MoveRight()
    {
        transform.Translate(Vector3.right * Time.deltaTime * strafeSpeed);
    }

    void SprintForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * sprintSpeed);
    }

    void Jump()
    {
        //Jumping Logic Here Sir!
    }
}
