using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfToSwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
            //check for truth with one object
            if(2+2 == 4)
        {
            print(true);
        }

        if (2 + 2 != 5)
        {
            print(true);
        }

        int nums = 2 + 2;
        //check for true and false in a single statement 
        if(nums == 5)
        {
            print(true);
        }
        else if (nums == 6)
        {
            print(nums);
        }
        else
        {
            print(false);
        }

        //use a switch to check for 3 or more values 
        switch (nums)
        {
            case 6:
                print("Well done you have " + nums);
                break;
            case 7:
                print("Too bad, you have " + nums);
                break;
            case 8:
                print("Stop drilling, you have " + nums);
                break; 

            default:
                print(nums);
                break;//switch is better than if because you are giving it specific things to do or it'll just go to default 
        }

        
	}
}
