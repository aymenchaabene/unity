using UnityEngine;
using System.Collections;

public class Collector : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D target) {
		if (target.tag == "Bomb" || target.tag == "Fruit") {
			target.gameObject.SetActive (false);
		}
	}

} // class
