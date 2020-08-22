using UnityEngine;
using System.Collections;

public class Collectorr : MonoBehaviour {

	private float width = 0f;

	// Use this for initialization
	void Awake () {
		width = GameObject.Find ("BG").GetComponent<BoxCollider2D> ().size.x;
	}
	
	void OnTriggerEnter2D(Collider2D target) {

		if (target.tag == "BG" || target.tag == "Ground") {
		
			Vector3 temp = target.transform.position;
			temp.x += width * 3;
			target.transform.position = temp;
		}

		if (target.tag == "Coin" || target.tag == "Rocket") {
			target.gameObject.SetActive (false);
		}

	}


} // class

































