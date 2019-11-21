using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMeun : MonoBehaviour {

	public void Level1Game() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	}

	public void Level2Game() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
	}

	public void Return() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
	}
}
