using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    //Put this on a camera that moves around the scene

    public Transform target; // Object you want to follow 

    private void Update()
    {
        transform.LookAt(target); //Looks at the object every frame
    }
}
