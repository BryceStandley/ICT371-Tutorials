using UnityEngine;
using UnityEngine.ParticleSystemJobs;
 [RequireComponent(typeof(ParticleSystem))]
public class ParticleJob : MonoBehaviour
{
    public ParticleSystem m_ParticleSystem;
    UpdateParticlesJob m_Job = new UpdateParticlesJob();
 
    private void Awake()
    {
        m_ParticleSystem = GetComponent<ParticleSystem>();
        MainStart();
    }
    public void MainStart()
    {
        Debug.Log("test");
        
        m_ParticleSystem.Simulate(2.0f);
        m_ParticleSystem.Play();
        
 
        var main = m_ParticleSystem.main;
        main.simulationSpeed = 0.0f;
        this.gameObject.SetActive(false);
    }
    void OnParticleUpdateJobScheduled()
    {
        m_Job.m_Time = Time.time;
        m_Job.Schedule(m_ParticleSystem);
    }
 
    //[BurstCompile] // Enable if using the Burst package
    struct UpdateParticlesJob : IJobParticleSystem
    {
        public float m_Time;
 
        public void Execute(ParticleSystemJobData particles)
        {
            var sizes = particles.sizes.x;
 
            for (int i = 0; i < particles.count; i++)
                sizes[i] = Mathf.Sin(m_Time) + 1.0f;
        }
    }
}