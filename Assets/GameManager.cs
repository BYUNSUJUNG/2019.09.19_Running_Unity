using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // replay()에서 사용됨

public class GameManager : MonoBehaviour {
	public int score;
	public GameObject winPanelObj, losePanelObj;

	void start() {
		Time.timeScale = 1f;
	}
	public void Win() {
		winPanelObj.SetActive(true);
		Time.timeScale = 0f;
//		Debug.Log("Win!");
	}

	public void Lose() {
		losePanelObj.SetActive(true);
		Time.timeScale = 0f;
//		Debug.Log("Lose!");
	}

	public void Replay() {
		SceneManager.LoadScene("Play");
	}
}
