using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class ParticleController : MonoBehaviour
{
    public ParticleSystem unityParticeSystem;
    public VisualEffect vfxGraph;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            unityParticeSystem.Play();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            vfxGraph.Play();
        }
    }
}
