using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class ParticleController : MonoBehaviour
{
    public ParticleSystem unityParticeSystem;
    public VisualEffect vfxGraph;

    public GameObject particleJobSystem;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            vfxGraph.Stop();
            particleJobSystem.SetActive(false);
            unityParticeSystem.Play();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            unityParticeSystem.Stop();
            particleJobSystem.SetActive(false);
            vfxGraph.Play();
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            unityParticeSystem.Stop();
            vfxGraph.Stop();
            particleJobSystem.SetActive(true);
        }
    }
}
