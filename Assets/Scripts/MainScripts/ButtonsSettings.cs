 using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsSettings : MonoBehaviour {

	public Sprite mus_on, mus_off;

	void Start (){
        if(gameObject.name == "Settings") {
            if (PlayerPrefs.GetString("Music") == "off")
            {
               transform.GetChild(0).gameObject.GetComponent<Image>().sprite = mus_off;
                Camera.main.GetComponent<AudioListener>().enabled = false;// swich off music
            }
		}
	}
     
	void OnMouseDown() {
		transform.localScale = new Vector3 (1.05f, 1.05f, 1.05f);
	}

	void OnMouseUp() {
		transform.localScale = new Vector3 (1f, 1f, 1f);
	}
	void OnMouseUpAsButton () {
        switch (gameObject.name) {
            case "DetectClicks":
                Application.LoadLevel("play");
                break;

            case "Rating":
                Application.OpenURL("");
                break;

            case "FaceBook":
                Application.OpenURL("https://www.facebook.com/profile.php?id=100017114176933");
                break;
            case "Twitter":
                Application.OpenURL("https://twitter.com/FallDuckInRiver");
                break;
            case "Music":

                if (PlayerPrefs.GetString("Music") == "off") //Music on
                {
                    GetComponent<Image>().sprite = mus_on;
                    PlayerPrefs.SetString("Music", "on");
                    Camera.main.GetComponent<AudioListener>().enabled = true;// swich on music

                }
                else { // Music off
                    GetComponent<Image>().sprite = mus_off;
                PlayerPrefs.SetString("Music", "off");
                    Camera.main.GetComponent<AudioListener>().enabled = false;// swich off music
                }

                break;

		case "Settings":
			for (int i = 0; i < transform.childCount; i++)
				transform.GetChild (i).gameObject.SetActive (!transform.GetChild (i).gameObject.activeSelf);
			break;
		}

	}
}