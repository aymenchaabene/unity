using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

	private float speed = 1f;
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = transform.position;
		temp.x -= speed * Time.deltaTime;
		transform.position = temp;
	}
}
