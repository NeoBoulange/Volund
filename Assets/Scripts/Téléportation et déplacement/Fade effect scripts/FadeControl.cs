using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class FadeControl : MonoBehaviour
{

    public GameObject fadeEffect;
    [SerializeField]
    private InputActionProperty m_Teleported;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Teleported.action.ReadValue<Vector2>() != Vector2.zero)
        {
            fadeEffect.SetActive(true);
        }
    }
}
