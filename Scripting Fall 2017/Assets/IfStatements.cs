using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour {


    public bool myBool;
    public string myString = "Dog";
    //both int's will default to 0
    public int num1;
    public int num2;

    // Use this for initialization
	void Start () {
        //if statements always default to false - if statements only run if block of code is true
        if (myBool)
        {
            print (true);
        }

        if(myString == "Cat")
        {
            print("Cat");
        }

        if(!myBool)
        {
            print(false);
        }

        //operator to check if something is not true !=
        if (myString != "Cat")
        {
            print(myString);
        }

        // == is checking for true, != is checking for false
        if (num1 + num2 == 7)
        {
            print(7);
            //this statement will be false because num1 and num2 are defaulted to 0
        }

        if(num1 + num2 != 7)
        {
            print(num1 + num2);
        }
	}

}
