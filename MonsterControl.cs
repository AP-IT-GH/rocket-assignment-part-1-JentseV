using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterControl : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float m_MovementSpeed;
    private Transform m_Rocket;
    void Start()
    {
        m_MovementSpeed = 3;
        m_Rocket = GameObject.Find("Rocket").GetComponent<Transform>();
        transform.position = new Vector3(38.5f,12,6.15f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(m_Rocket);
        transform.position += transform.forward * m_MovementSpeed * Time.deltaTime ;
    }
}
