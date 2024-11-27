using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInputController : MonoBehaviour
{

    [HideInInspector] public Vector3 ballDirectiion;
    void Start()
    {
        ballDirectiion = Vector3.left;
    }

    void Update()
    {
        HandleBallInputs();
    }
    private void HandleBallInputs(){
        if(Input.GetMouseButtonDown(0)){
            ChangeBallDirection();
        }
    }
    private void ChangeBallDirection(){
        if(ballDirectiion.x == -1) {
           ballDirectiion = Vector3.forward;
        } else {
            ballDirectiion = Vector3.left;
        }
    }
}