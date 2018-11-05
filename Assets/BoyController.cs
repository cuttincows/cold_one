using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoyController : MonoBehaviour {

	[HideInInspector] private bool hasBeenBeered = false;
	public string successText = "Thanks bro";
	Transform prompt;
	Text promptText;
	private Rigidbody rBody;

	public float forceScalar = 5.0f;

	public bool HasBeenBeered
	{
		get
		{
			return hasBeenBeered;
		}

		set
		{
			hasBeenBeered = value;
		}
	}

	public void GetAColdOne(Collision coldOne)
	{
		promptText.text = successText;
		rBody.isKinematic = false;
		rBody.AddForceAtPosition(coldOne.relativeVelocity * forceScalar, coldOne.transform.position);
	}

	// Use this for initialization
	void Start () {
		prompt = transform.Find("ColdOnePrompt");
		promptText = GetComponentInChildren<Text>();
		rBody = GetComponent<Rigidbody>();
		print(promptText);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
