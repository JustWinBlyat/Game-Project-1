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
    // Start is called before the first frame update
    void Start()
    {
        GetRigidbody();
    }

    // Update is called once per frame
    void Update()
    {
        MoveVertical();
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
        float forwardInput = Input.GetAxis("PlayerVertical");
    
        playerRigidbody.AddForce(Vector3.forward * forwardInput * speed);
    }
}
