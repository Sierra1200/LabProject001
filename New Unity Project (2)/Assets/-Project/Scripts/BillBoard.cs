using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoard : MonoBehaviour {

    public GameObject gameObject;

	void Update () {
		Vector3 pos = Camera.main.transform.position;
		pos.y = transform.position.y;	// カメラの位置を格納
		transform.LookAt(pos);	// カメラの方向を向く
		transform.Rotate(new Vector3(0, 0, 1), -90);	// 図の向きを調整
	}

    // マーカーを消すメソッド
    public void ActiveToFalse() {
        gameObject.SetActive(false);
        Debug.Log("Marker:false");
    }
}
