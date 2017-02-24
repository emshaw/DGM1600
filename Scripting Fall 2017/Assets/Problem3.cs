using UnityEngine;
using System.Collections;


//PROBLEM: Create 3 Buttons, Add New Script to each button, Write a function (void) that adds an element to the myElements list (animals), Configure the button to run the function that adds the element to the list

public class Problem3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.A))
        {
            print("Aardvark");
        }
        if (Input.GetKey(KeyCode.S))
        {
            print("Sloth");
        }
        if (Input.GetKey(KeyCode.D))
        {
            print("Dingo");
        }
        
	}
}
