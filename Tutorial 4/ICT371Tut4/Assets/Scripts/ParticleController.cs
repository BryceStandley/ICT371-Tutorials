using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public ParticleSystem unityParticeSystem;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            unityParticeSystem.Play();
        }
    }
}
