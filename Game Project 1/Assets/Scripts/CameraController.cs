using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform target; //The target object to follow (The Player Object)

    [Space]

    [SerializeField]
    private float rotationSpeed = 50f; //Rotation speed at which the camera rotates

    private Vector3 offset; //Initial Offset of the camera

    void Start()
    {
        offset = target.position - transform.position;
    }

    void LateUpdate()
    {
        //Get horizontal input
        float horizontalInput = Input.GetAxis("Horizontal");

        //Rotate around the player
        target.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);

        //Maintain original offset position
        float desiredYAngle = target.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredYAngle, 0);
        transform.position = target.position - (rotation * offset);

        //Look at the player object
        transform.LookAt(target);
    }
}