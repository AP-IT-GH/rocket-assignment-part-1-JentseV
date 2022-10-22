using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] private float m_ThurstPower =6;
    private Rigidbody m_Rigidbody;
    private Transform m_RigidboyTransform;
    
    private void Start()
    {
        
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.maxAngularVelocity = 20;
        m_RigidboyTransform = m_Rigidbody.GetComponent<Transform>();
    }


    public void Move(Vector3 moveDirection)
    {
        moveDirection.z=0;
        m_Rigidbody.AddRelativeForce(moveDirection*m_ThurstPower);

    }

    public void Rotate(Vector3 rorateDirection){
        m_RigidboyTransform.Rotate(rorateDirection * (m_ThurstPower/2),Space.Self);
    }
}
