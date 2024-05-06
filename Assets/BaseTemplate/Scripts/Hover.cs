using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hover : MonoBehaviour
{
    [Header("Events Config")]
    public string[] m_Tag;
    public bool m_DoOnce = true;
    [Header("Interactable Events")]
    [Header("Hover")]
    public UnityEvent HoverEntered;
    public UnityEvent HoverExited;

    private string m_FindTag;
    private bool m_FirstTime = false;
    private bool m_Hover = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Begin Hover");

        if (m_DoOnce && !m_FirstTime)
        {
            m_FirstTime = true;
        }
        else if (m_FirstTime)
        {
            return;
        }

        foreach (var tag in m_Tag)
        {
            if (other.gameObject.CompareTag(tag))
            {
                Debug.Log("Begin Find");
                HoverEntered.Invoke();
                m_FindTag = tag;
                m_Hover = true;
                break;
            }
            else
            {
                m_FindTag = "None";
            }

        }

    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("End Hover");

        if (other.gameObject.CompareTag(m_FindTag) && m_Hover)
        {
            Debug.Log("End Find");
            HoverExited.Invoke();
            m_Hover = false;
        }
    }
}
