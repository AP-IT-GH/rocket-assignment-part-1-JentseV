using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketControl : MonoBehaviour
{
   private Rocket rocket;
   private Vector3 move;
   private Vector3 rotate;

   private void Awake() {
    rocket = GetComponent<Rocket>();
   }

   private void Update() {
    rotate = Vector3.zero;
    move = Vector3.zero;
    if(Input.GetKey("left")){
        move = Vector3.left;
        rotate = (Vector3.forward).normalized;
    } 
    if(Input.GetKey("right")){
       move = Vector3.right;
       rotate = (Vector3.back ).normalized;
    } 
    if(Input.GetKey("space")){
        move = Vector3.up;
        rocket.GetComponent<Rigidbody>().useGravity = false;
    }else{
        rocket.GetComponent<Rigidbody>().useGravity = true;
    }
   
   }

   private void FixedUpdate() {
    rocket.Rotate(rotate);
    rocket.Move(move);
    
   }
}
