using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentralRotation : MonoBehaviour
{
    [SerializeField]
    public float sensitivity = 50f; //Speed at which the center rotates.

    void Start()
    {
        
    }

    void Update()
    {
        RotateCenter();
    }

    void RotateCenter()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * sensitivity);
    }
}
