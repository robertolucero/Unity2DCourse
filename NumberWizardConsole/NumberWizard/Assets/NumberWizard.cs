using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{

		var max = 1000;
		var min = 1;

		Debug.Log("Welcome to number wizard, yo");
		Debug.Log("Pick a number...");
		Debug.Log("Highest number you can pick is: " + max);
		Debug.Log("Lowest number you can pick is: " + min);
		Debug.Log("Tell me if your number is higher or lower than 500");
		Debug.Log("Push 9 = Higher, Push Down = Lower, Push Enter = Correct");


	}
	
	// Update is called once per frame
	void Update () 
	{
		//Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.Keypad9))
            Debug.Log("Up Arrow key was pressed.");

	}
}
