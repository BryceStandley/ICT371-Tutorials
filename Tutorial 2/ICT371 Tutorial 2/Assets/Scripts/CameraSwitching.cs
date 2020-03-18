using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitching : MonoBehaviour
{
    public GameObject[] cameras;

    private int index = 1;
    public Vector3 origPos, fpvPos;

    private void Start()
    {
        origPos = cameras[0].transform.position;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            foreach (GameObject camera in cameras)
            {
                camera.SetActive(false);
            }
            cameras[index].SetActive(true);
            index++;
            if(index == cameras.Length)
            {
                index = 0;
            }
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            foreach(GameObject camera in cameras)
            {
                camera.SetActive(false);
            }
            cameras[0].SetActive(true);
            if(cameras[0].transform.position == origPos)
            {
                cameras[0].transform.position = fpvPos;
            }
            else
            {
                cameras[0].transform.position = origPos;
            }
        }
    }
}
