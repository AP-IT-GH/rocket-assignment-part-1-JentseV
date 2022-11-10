using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCollder : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        speed = 95;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate((Vector3.up*Time.deltaTime*speed)*-1);

        
    }

    private void OnTriggerEnter(Collider other) {
        GameObject obstacle4 = GameObject.Find("Obstacle 4");
        if(other.gameObject.tag == "rocket" && obstacle4 != null){
            Destroy(obstacle4);
            Destroy(GameObject.Find("Coin"));
            GameObject.Find("Rocket").GetComponent<Score>().AddPoint(1);
        }
    }
}
