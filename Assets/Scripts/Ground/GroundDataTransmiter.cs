using UnityEngine;

public class GroundDataTransmiter : MonoBehaviour
{
    [SerializeField] private GroundFallController groundFallController;
    public void SetGroundRigidBodyValue(){
        StartCoroutine(groundFallController.SetRigidBodyValue());
        }
}