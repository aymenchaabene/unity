﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerrScore : MonoBehaviour {

	private Text scoreText;
	private int score = 0;

	void Awake () {
		scoreText = GameObject.Find ("ScoreText").GetComponent<Text> ();
		scoreText.text = "0";
	}
	
	void OnTriggerEnter2D(Collider2D target) {
			
		if (target.tag == "Coin") {
			score++;
			scoreText.text = score.ToString ();
			target.gameObject.SetActive (false);
		}

		if (target.tag == "Rocket") {
			transform.position = new Vector3 (0, 1000, 0);
			target.gameObject.SetActive (false);
			StartCoroutine (RestartGame ());
		}

	}

	IEnumerator RestartGame() {
		yield return new WaitForSecondsRealtime (2f);
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}

} // class



































