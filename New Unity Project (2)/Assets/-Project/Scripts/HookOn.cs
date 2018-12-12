using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookOn : MonoBehaviour {

	public GameObject load;	// クレーンで吊るす荷物
	public GameObject hook;
	private Vector3 pos;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		pos = hook.transform.position;
		load.transform.position = new Vector3 (pos.x, pos.y - 1f, pos.z); // load(荷物)をhookに追従させる
	}
}
