using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	private bool canMove;

	private float distance = 4.1f;
	private float newDestination;

	void OnEnable() {
		PlayerScript.move += Move;
	}

	void OnDisable() {
		PlayerScript.move -= Move;
	}

	void Update () {
		MoveCamera ();
	}

	private void MoveCamera() {
		if (canMove) {
			Vector3 temp = transform.position;
			temp.y += 3f * Time.deltaTime;
			transform.position = temp;

			if (transform.position.y >= newDestination) {
				canMove = false;
			}
		}
	}

	void Move() {
		newDestination = transform.position.y + distance;
		canMove = true;
	}

} // class

































