using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class MainWindow : MonoBehaviour, IView
{
    public MainWindowController WindowController
    {
        get
        {
            return _mainWindowController;
        }

        set
        {
            if (_mainWindowController != value)
            {
                _mainWindowController.UnSubscribeFromButtons();
                _mainWindowController = value;
            }
        }
    }
    private MainWindowController _mainWindowController;

    [Inject]
    public void Construct (MainWindowController controller)
    {
        Debug.Log("In constructor ");
        WindowController = controller;
    }



    void Start () {
		
	}
	
	void Update () {
		
	}
}
