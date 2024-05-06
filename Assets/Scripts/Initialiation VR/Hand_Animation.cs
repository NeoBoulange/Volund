using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.InputSystem;

public class Hand_Animation : MonoBehaviour
{
    public Animator m_Animator;
    public InputActionProperty m_PinchAction;
    public InputActionProperty m_GripAction;

    void Update()
    {
        m_Animator.SetFloat("Trigger", m_PinchAction.action.ReadValue<float>());
        m_Animator.SetFloat("Grip", m_GripAction.action.ReadValue<float>());
    }
}
