using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Activate_Telrport_Ray : MonoBehaviour
{
    public GameObject m_TeleportRay;
    public InputActionProperty m_Teleport;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (m_Teleport.action.ReadValue<Vector2>() != Vector2.zero) 
        {
            m_TeleportRay.SetActive(true);
        }

        else
        {
            m_TeleportRay.SetActive(false);
        }
        
            
    }
}
