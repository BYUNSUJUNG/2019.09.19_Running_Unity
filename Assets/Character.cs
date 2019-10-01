using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

	public float moveSpeed = 2f;
	public float jumpPower = 300f;

	public GameManager gameManager;
	//public GameObject gameManager;

	void Update () {
		// Uadate 프레임 시간 차 * Time.Timescale = Time.deltaTime
		transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
	}

	public void Jump() {
		GetComponent<Rigidbody2D>().AddForce(Vector3.up*jumpPower);
	}

	void OnTriggerEnter2D(Collider2D col) {
		if(col.transform.name == "WinCollider") {
			gameManager.Win();
		} else if (col.transform.name == "LoseCollider") {
			gameManager.Lose();
		}
	}
}
