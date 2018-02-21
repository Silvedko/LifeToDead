using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectClicks : MonoBehaviour {
	public GameObject buttons, music ;
	public Text playTxt, gameName, timerOut, textTimer, Advice;

	private bool clicked;

	void OnMouseDown () {
		if (!clicked) { // Срабатывает один раз
			clicked = true;
			playTxt.gameObject.SetActive (false);
			gameName.gameObject.SetActive (false);
            //Hide settings if active
            if (music.activeSelf)
                for (int i = 0; i < music.transform.parent.transform.childCount; i++)
                    music.transform.parent.transform.GetChild(i).gameObject.SetActive(!music.transform.parent.transform.GetChild(i).gameObject.activeSelf);

			timerOut.gameObject.SetActive (false);
			textTimer.gameObject.SetActive (false);
			Advice.gameObject.SetActive (false);
		}
	}
}
