using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour {
	private float CurrentTime;
	private float LastTime;
	// Use this for initialization
	void Start () {
		LastTime = 0;
		//Заносим данные
		if (PlayerPrefs.HasKey ("LifeTime")) 
		{
			CurrentTime = PlayerPrefs.GetFloat ("LifeTime");
		}

		else 
		
		{
			CurrentTime = 0;
			PlayerPrefs.SetFloat ("LifeTime", 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (CurrentTime - 1 >= LastTime )
		{
	PlayerPrefs.SetFloat("Life", CurrentTime);
	}

	CurrentTime += Time.deltaTime;
	
	}
	//Положение  счетчика на главной сцене
	void OnGUI (){
		GUI.Label(new Rect(Screen.width/2-10, Screen.height/2-10, 100, 100), "Time now: " + CurrentTime);
	}
}
