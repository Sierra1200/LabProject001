using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Target") {
			Debug.Log("Hit" + col.gameObject.name);
			GetComponent<HookOn>().enabled = false;
		}
	}
}
