
using UnityEngine;

public class GroundCollisionController : MonoBehaviour
{
    private void OnCollisionExit(Collision other){
        if (other.gameObject.CompareTag("Ball")){
            
        }
    }
}