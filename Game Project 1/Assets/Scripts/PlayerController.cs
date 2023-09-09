using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Player Movement
    [SerializeField]
    private float speed = 5.0f;
    //Player Component
    private Rigidbody playerRigidbody;
    private GameObject focalPoint;

    // Start is called before the first frame update
    void Start()
    {
        GetRigidbody();
        GetFocalPoint();
    }

    // Update is called once per frame
    void Update()
    {
        MoveVertical();
        MoveHorizontal();
    }

    //Gets the object's rigidbody component and calls it to the Start() method.
    void GetRigidbody()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void MoveVertical()
    {
        //Make sure the input manager name PlayerVertical is found.
        //This is meant to separate the Camera's movement binding from the player's.
        float verticalInput = Input.GetAxis("PlayerVertical");
    
        playerRigidbody.AddForce(focalPoint.transform.forward * verticalInput * speed);
    }

    void MoveHorizontal()
    {
        float horizontalInput = Input.GetAxis("PlayerHorizontal");

        playerRigidbody.AddForce(focalPoint.transform.right * horizontalInput * speed);
    }

    void GetFocalPoint()
    {
        focalPoint = GameObject.Find("Center");
    }
}
