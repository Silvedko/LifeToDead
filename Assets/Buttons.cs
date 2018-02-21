using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

	void OnMouseDown (){
		transform.localScale = new Vector3 (0.55f, 0.55f, 0.55f);
	}
	void OnMouseUp (){
		transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
	}
}
