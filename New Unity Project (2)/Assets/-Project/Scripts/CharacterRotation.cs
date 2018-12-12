using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour {

	public float speed = 2.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate () {
		transform.position += transform.forward * speed * Time.deltaTime;
	}

	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "CornerPoint1") {
			Debug.Log("Touch:CornerPoint (1)");
			transform.Rotate(0, -90, 0);
		}
	}
}
