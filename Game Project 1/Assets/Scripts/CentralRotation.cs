using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentralRotation : MonoBehaviour
{
    [SerializeField]
    private GameObject center; //This is a reference to the center point in our arena

    [Space]

    [SerializeField]
    private KeyCode leftTurn = KeyCode.LeftArrow;
    [SerializeField]
    private KeyCode rightTurn = KeyCode.RightArrow;

    [Space]

    [SerializeField]
    private float rotationSpeed = 50f;

    private Transform cameraTransform; //Transform of the main camera

    void Start()
    {
        //Gets the main camera's transform
        cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        CameraSpinner();
    }

    void CameraSpinner()
    {
        float rotation = 0f;

        //Right Rotation:
        if (Input.GetKey(rightTurn))
        {
            rotation = -rotationSpeed * Time.deltaTime;
        }

        //Left Rotation:
        if (Input.GetKey(leftTurn))
        {
            rotation = rotationSpeed * Time.deltaTime;
        }

        //Rotate the camera around the center:
        cameraTransform.RotateAround(center.transform.position, Vector3.up, rotation);
    }
}
