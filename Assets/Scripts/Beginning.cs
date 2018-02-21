using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Beginning : MonoBehaviour {

	public void NewGame()
	{
		SceneManager.LoadScene("play");
	}

	public void Exit()
	{
		Application.Quit ();
	}
}