using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//FOr loading scene
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

	private void Update()
	{
		if(Input.anyKeyDown)
		{
			NextScene();
		}
	}
	public void NextScene()
	{
		//Get the current scene
		Scene currentScene = SceneManager.GetActiveScene();
		//Load the next scene aftercrurent scene
		SceneManager.LoadScene(currentScene.buildIndex + 1);
	}

}