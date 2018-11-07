using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldLocal : MonoBehaviour {

	public Transform parent;
	public Transform child;

	// Use this for initialization
	void Start () {

		// ワールド座標でのデータ
		Debug.Log ("ParentWorld:" + parent.position + "|" + parent.eulerAngles + "|" + parent.lossyScale);
		Debug.Log ("ChildWorld:" + child.position + "|" + child.eulerAngles + "|" + child.lossyScale);

		// ローカル座標でのデータ
		Debug.Log ("ParentLocal:" + parent.localPosition + "|" + parent.localEulerAngles + "|" + parent.localScale);
		Debug.Log ("ChildLocal:" + child.localPosition + "|" + child.localEulerAngles + "|" + child.localScale);
	}
	
	// Update is called once per frame
	void Update () {

		// ワールド座標でのデータ
		Debug.Log ("ParentWorld:" + parent.position + "|" + parent.eulerAngles + "|" + parent.lossyScale);
		Debug.Log ("ChildWorld:" + child.position + "|" + child.eulerAngles + "|" + child.lossyScale);

		// ローカル座標でのデータ
		Debug.Log ("ParentLocal:" + parent.localPosition + "|" + parent.localEulerAngles + "|" + parent.localScale);
		Debug.Log ("ChildLocal:" + child.localPosition + "|" + child.localEulerAngles + "|" + child.localScale);
	}
}
