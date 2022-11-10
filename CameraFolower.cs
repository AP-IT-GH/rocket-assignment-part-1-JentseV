using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolower : MonoBehaviour
{
    
    public Transform rocket;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = rocket.transform.position + new Vector3(0,0,-20);
    }
}
