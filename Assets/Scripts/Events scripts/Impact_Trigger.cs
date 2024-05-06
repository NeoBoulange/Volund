using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impact_Trigger : MonoBehaviour
{
    [SerializeField]
    private AudioSource impactSound;

    private void OnTriggerEnter(Collider col)
    {
        Debug.Log("Collider impactés");
        impactSound.Play();
    }
}
