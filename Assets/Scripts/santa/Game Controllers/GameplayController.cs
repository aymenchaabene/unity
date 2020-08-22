using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameplayController : MonoBehaviour {

	public static GameplayController instance;

	[SerializeField]
	private GameObject platform ;

	private float DISTANCE_BETWEEN_PLATFORMS = 4.1f;
	private int countPlatforms;
	private float lastPlatformPositionY;

	// Use this for initialization
	void Awake () {
		MakeSingleton ();
		CreatePlatform ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnDisable() {
		instance = null;
	}

	private void MakeSingleton() {
		if (instance == null) 
			instance = this;
	}

	public void CreatePlatform() {
		lastPlatformPositionY += DISTANCE_BETWEEN_PLATFORMS;

		GameObject newPlatform = Instantiate (platform);
		newPlatform.transform.position = new Vector3 (0, lastPlatformPositionY, 0);
		newPlatform.name = "Platform " + countPlatforms;

		countPlatforms++;

	}

	public void PlayAgain() {
		Time.timeScale = 1;
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}

	public void GoToMenu() {
		Time.timeScale = 1;
		SceneManager.LoadScene ("MainMenu");
	}
	 
} // class






































