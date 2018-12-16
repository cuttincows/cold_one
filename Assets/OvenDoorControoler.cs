using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvenDoorControoler : MonoBehaviour
{
	private Rigidbody rBody;
	public Transform forcePoint;

	public float forceScalar = 500f;

	// Use this for initialization
	void Start ()
	{
		rBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		rBody.AddForceAtPosition(
			forcePoint.forward * forceScalar,
			forcePoint.position
		);
	}
}
