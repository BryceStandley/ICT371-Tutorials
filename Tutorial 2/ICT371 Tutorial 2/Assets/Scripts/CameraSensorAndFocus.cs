using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSensorAndFocus : MonoBehaviour
{
    public Camera cam;

    public void OnFocalChange(float input)
    {
        cam.focalLength = input;
    }

    public void OnSensorChange(float input)
    {
        input = (int)input;
        switch(input)
        {
            case 0: //8mm
                cam.sensorSize = new Vector2(4.8f, 3.5f);
                break;

            case 1: //super 8mm
                cam.sensorSize = new Vector2(5.79f, 4.01f);
                break;

            case 2: //16mm
                cam.sensorSize = new Vector2(10.26f, 7.49f);
                break;

            case 3: //Super 16mm
                cam.sensorSize = new Vector2(12.52f, 7.41f);
                break;

            case 4: //35mm 2-perf
                cam.sensorSize = new Vector2(21.95f, 9.35f);
                break;

            case 5: //35mm Acadamy
                cam.sensorSize = new Vector2(21f, 15.2f);
                break;

            case 6: //Super 35mm
                cam.sensorSize = new Vector2(24.89f, 18.66f);
                break;

            case 7: //65mm ALEXA
                cam.sensorSize = new Vector2(54.12f, 25.59f);
                break;

            case 8: //70mm
                cam.sensorSize = new Vector2(70f, 51f);
                break;

            case 9: //70mm IMAX
                cam.sensorSize = new Vector2(70.41f, 52.63f);
                break;

        }


    }
}
