using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 30f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, 5f, 0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
