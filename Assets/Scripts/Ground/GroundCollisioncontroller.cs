using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisionController : MonoBehaviour
{
    [SerializeField] private GroundDataTransmiter groundDataTransmiter;
    
    private void OnCollisionExit(Collision other){
        if(other.gameObject.CompareTag("Ball")){
            groundDataTransmiter.SetGroundRigidBodyValue();
        }
    }
}
