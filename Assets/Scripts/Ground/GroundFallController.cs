using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundFallController : MonoBehaviour
{
	
	private Rigidbody rb;
	
	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
	
	public IEnumerator SetRigidBodyvalue()
	
	{
		yield return new WaitForSeconds(0.8f);
		rb.isKinematic = false;
		rb.useGravity = true;
		
	}


	
}
