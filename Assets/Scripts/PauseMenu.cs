﻿using UnityEngine;
using System.Collections;

/**
* ...
* @author Joel Limes
* ...
**/

public class PauseMenu : MonoBehaviour 
{
	[SerializeField]
	private bool isPaused;

	[SerializeField]
	private GameObject pauseMenuCanvas;


	// Update is called once per frame
	void Update () 
	{
		if (isPaused) {
			pauseMenuCanvas.SetActive (true);
			Time.timeScale = 0f;
		} 
		else {
			pauseMenuCanvas.SetActive (false);
			Time.timeScale = 1f;
		}

		if (Input.GetKeyDown (KeyCode.P)) 
		{
			isPaused = !isPaused;
		}
	}

	public void Resume()
	{
		isPaused = false;
	}
}
