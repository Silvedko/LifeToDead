using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer2 : MonoBehaviour {

	public int textTimer = 5;
		public Text countdownText;

		// Use this for initialization
		void Start()
		{
        countdownText = GetComponent<Text>();
			StartCoroutine("LoseTime");
		}

		// Update is called once per frame
		void Update()
		{
		countdownText.text = ( "" + textTimer );
		float Tim = textTimer;
		if (Tim <= 1)
			{
				StopCoroutine("LoseTime");
			Tim -= Time.deltaTime;
			countdownText.text = textTimer.ToString ("f7");

			}
		}

		IEnumerator LoseTime()
		{
			while (true)
			{
				yield return new WaitForSeconds(1);
			textTimer--;
			}
		}
	}