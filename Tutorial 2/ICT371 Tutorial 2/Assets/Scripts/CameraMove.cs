using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float distanceToMove = 8f;

    private void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time, distanceToMove), transform.position.y, transform.position.z);
    }
}
