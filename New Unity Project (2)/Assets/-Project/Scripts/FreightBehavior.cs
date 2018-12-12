using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreightBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider other) {

		/*
		if (other.gameObject.tag == "Hook") {
			Debug.Log("collider");
		}
		*/

		/*
		if (collider.gameObject.CompareTag("Hook")) {
			Debug.Log("collider");
		}
		*/

		Debug.Log (other.name + "Enter");
	}

	void OnTriggerStay (Collider other) {
		Debug.Log (other.name + "Stay");
	}

	void OntriggerExit (Collider other) {
		Debug.Log (other.name + "Exit");
	}
}
