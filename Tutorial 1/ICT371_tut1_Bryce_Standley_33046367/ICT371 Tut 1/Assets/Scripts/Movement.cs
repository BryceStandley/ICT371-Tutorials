using System.Collections;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 newPosition;
    public Vector3 newRotation;

    public void RotateLeft()
    {
        newPosition = Vector3.zero; //Stopping any movement
        newRotation = new Vector3(0, -0.5f, 0); //Setting Y rotation to rotate left
    }

    public void RotateRight()
    {
        newPosition = Vector3.zero;
        newRotation = new Vector3(0, 0.5f, 0);
    }

    public void MoveLeft()
    {
        newRotation = Vector3.zero;//Stopping any rotation
        newPosition = Vector3.left;//Setting the new position to the given direction
        StartCoroutine(StopMovement());//Starting a delay to stop movement
    }

    public void MoveRight()
    {
        newRotation = Vector3.zero;
        newPosition = Vector3.right;
        StartCoroutine(StopMovement());
    }

    public void MoveUp()
    {
        newRotation = Vector3.zero;
        newPosition = Vector3.up;
        StartCoroutine(StopMovement());
    }

    public void MoveDown()
    {
        newRotation = Vector3.zero;
        newPosition = Vector3.down;
        StartCoroutine(StopMovement());
    }

    public void MoveForward()
    {
        newRotation = Vector3.zero;
        newPosition = Vector3.forward;
        StartCoroutine(StopMovement());
    }

    public void MoveBack()
    {
        newRotation = Vector3.zero;
        newPosition = Vector3.back;
        StartCoroutine(StopMovement());
    }

    void Update()//Code here will be called once per frame
    {
        transform.Translate(newPosition * Time.deltaTime, Space.Self);// Moving in local space in the given direction using delta time to give smooth movement
        transform.Rotate(0, newRotation.y, 0, Space.Self);// Rotating alog the Y axis in local space with the given vector
    }

    IEnumerator StopMovement()
    {
        yield return new WaitForSeconds(1.2f);// Waiting 1.2 seconds before continuing this function
        newPosition = Vector3.zero;//Clearing any movement by zeroing the vector

    }
}
