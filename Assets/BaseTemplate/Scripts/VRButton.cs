using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VRButton : MonoBehaviour
{
    [Header("Settings")]
    public bool m_DoOnce = false;
    public GameObject m_PressPart;
    [Header("Interactable Events")]
    [Header("Press")]
    public UnityEvent OnPress;
    public UnityEvent OnRelease;

    private bool m_PressState = false;
    private bool m_IsLock = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!m_PressState && !m_IsLock && other.CompareTag("Hand"))
        {
            m_PressPart.transform.localPosition = new Vector3(0f, 0.025f, 0f);
            m_PressState = true;
            OnPress.Invoke();

            if (m_DoOnce)
            {
                m_IsLock = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (m_PressState && !m_IsLock && other.CompareTag("Hand"))
        {
            m_PressPart.transform.localPosition = new Vector3(0f, 0.05f, 0f);
            m_PressState = false;
            OnRelease.Invoke();
        }
    }
}
