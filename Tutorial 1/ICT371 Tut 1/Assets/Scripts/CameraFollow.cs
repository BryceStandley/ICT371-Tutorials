using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform modelToLookAt;

    public void LookAtObject()
    {
        transform.LookAt(modelToLookAt, Vector3.up); // Always look at the model in space
    }
}
