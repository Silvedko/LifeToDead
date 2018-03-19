using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainWindowController : MonoBehaviour
{

    public void SubscribeOnButtons ()
    {

    }

    public void UnSubscribeFromButtons ()
    {
        Debug.Log("hi there, man!");
    }

    void Start ()
    {
        SubscribeOnButtons();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
