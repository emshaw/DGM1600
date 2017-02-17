using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatements : MonoBehaviour {

    //switches are for more than 2 answers
    //fastest code is the code that never runs 
    //a solutiong to if else clauses - better because it's checking for specific things - if you need to check for more than 2 things, use a switch statement
    //enums are elimintating all the possibilities - narrows it down a ton - enums are data 

    public enum Colors {RED, GREEN, BLUE};//enums are objects - the nice thing is you can add more choices whenever you want 
    public Colors color; 

    public enum GameStates
    {
        LOADING,
        STARTING,
        PLAYING,
        ENDING
    }

    public GameStates currentGameState = GameStates.LOADING;


	// Use this for initialization
	void Start () {
		
        switch (color)
        {
            case Colors.RED:
                print("Red");//not checking if something is true or false, checking if something is green
                break;

            case Colors.GREEN:
                print("Green");
                break;

            case Colors.BLUE:
                print("Blue");
                break;

            default://if it's not green, red, or blue, it will just print "color" - default means print any other situation - default is used for switch statements but enums don't need a default  
                print(color);
                break;
        }

	}
	

		
}

