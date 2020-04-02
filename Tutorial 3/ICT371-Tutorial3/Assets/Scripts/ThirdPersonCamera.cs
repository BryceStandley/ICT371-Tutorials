using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour
{

    public bool lockCursor;
    public float mouseSensitivity = 10;
    public Transform target;
    public float dstFromTarget = 2;
    public float cameraColOffset = 0.9f;
    public Vector2 pitchMinMax = new Vector2(-40, 85);

    public float rotationSmoothTime = .12f;
    Vector3 rotationSmoothVelocity;
    Vector3 currentRotation;

    float yaw;
    float pitch;

    Ray ray;
    RaycastHit hit;

    void Start()
    {
        if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        
    }

    private void LateUpdate()
    {
        yaw += Input.GetAxis("Mouse X") * mouseSensitivity;
        pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        pitch = Mathf.Clamp(pitch, pitchMinMax.x, pitchMinMax.y);

        currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(pitch, yaw), ref rotationSmoothVelocity, rotationSmoothTime);
        transform.eulerAngles = currentRotation;

        transform.position = target.position - transform.forward * dstFromTarget;

        CameraMove();
        transform.LookAt(target);

    }

    private void CameraMove()
    {
        ray = new Ray(transform.position, transform.forward * -1);
        hit = new RaycastHit();
        Debug.DrawLine(target.position, transform.position, Color.red, 5f);

        if (Physics.Linecast(target.position, transform.position, out hit))
        {
            Vector3 moveTo = new Vector3(hit.point.x + hit.normal.x * 0.5f, transform.position.y, hit.point.z + hit.normal.z * 0.5f);
            transform.position = moveTo;

        }
 
    }


}