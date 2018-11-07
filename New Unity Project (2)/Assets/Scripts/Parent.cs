using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : MonoBehaviour {

	public GameObject object_child;
	public GameObject object_parent;

	// Use this for initialization
	void Start () {

		object_child.transform.parent = object_parent.transform;
	}
	
	// Update is called once per frame
	void Update () {

		object_child.transform.rotation = Quaternion.Euler (0, 0, 0); // オブジェクトを回転させない処理
	}
}
