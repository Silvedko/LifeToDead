using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Very Important

public class myTimer : MonoBehaviour {

	public float myCoolTimer = 100000000000;
	public Text timerText;
	// Use this for initialization
	void Start () {
		timerText = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {
		float tim = myCoolTimer;
		if (tim >= 0.1)
			myCoolTimer -= Time.deltaTime;
			timerText.text = myCoolTimer.ToString ("f7");
			print (myCoolTimer);
		
	}
}
