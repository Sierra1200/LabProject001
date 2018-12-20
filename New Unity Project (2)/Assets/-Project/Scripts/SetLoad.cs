using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLoad : MonoBehaviour {

    private GameObject gameObject;
    private BillBoard billBoard;

	// Use this for initialization
	void Start () {
        gameObject = GameObject.Find("ImageMarker");
        billBoard = gameObject.GetComponent<BillBoard>();
	}

	// Update is called once per frame
	void Update () {

	}

	// "Target"タグのオブジェクトに接触したら、吊り荷を離すメソッド
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Target") {
			Debug.Log("Hit" + col.gameObject.name);
			GetComponent<HookOn>().enabled = false;
            billBoard.ActiveToFalse();
		}
	}
}
