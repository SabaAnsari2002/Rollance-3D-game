using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisioncontroller : MonoBehaviour
{
    private void OnCollisionExit(collision other)
    {
    	if(other.gameObject.Camparetag("Ball"))
        {
        	
        }
    }
}
