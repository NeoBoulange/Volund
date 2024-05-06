using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleConveyor : MonoBehaviour
{
    public float m_Speed;
    Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 pos = m_Rigidbody.position;
        m_Rigidbody.position += -gameObject.transform.forward * m_Speed * Time.fixedDeltaTime;
        m_Rigidbody.MovePosition(pos);
    }
}
