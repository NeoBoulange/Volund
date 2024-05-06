using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Rigidbody))]
public class HitObject : MonoBehaviour
{
    public float m_MagnitudeMax = 0.1f;

    private AudioSource m_AudioSource;
    private Rigidbody m_Rigidbody;

    private void Start()
    {
        m_AudioSource = gameObject.GetComponent<AudioSource>();
        m_Rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(m_AudioSource && m_Rigidbody)
        {
            if (m_Rigidbody.velocity.magnitude >= m_MagnitudeMax)
            {
                m_AudioSource.Play();
            }
        }
    }
}
