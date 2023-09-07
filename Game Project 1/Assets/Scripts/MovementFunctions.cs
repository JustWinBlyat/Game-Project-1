using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFunctions : MonoBehaviour
{
    public static void MoveForward(Transform transform, float walkingSpeed)
    {
        transform.Translate(Vector3.forward * Time.deltaTime * walkingSpeed);
    }

    public static void MoveBackward(Transform transform, float walkingSpeed)
    {
        transform.Translate(Vector3.back * Time.deltaTime * walkingSpeed);
    }

    public static void MoveLeft(Transform transform, float strafeSpeed)
    {
        transform.Translate(Vector3.left * Time.deltaTime * strafeSpeed);
    }

    public static void MoveRight(Transform transform, float strafeSpeed)
    {
        transform.Translate(Vector3.right * Time.deltaTime * strafeSpeed);
    }

    public static void SprintForward(Transform transform, float sprintSpeed)
    {
        transform.Translate(Vector3.forward * Time.deltaTime * sprintSpeed);
    }

    //void Jump()
    //{
    //    //Jumping Logic Here Sir!
    //}
}
