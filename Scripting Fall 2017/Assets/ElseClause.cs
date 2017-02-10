using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElseClause : MonoBehaviour {

    public bool myBool;
    public string password;
    public bool userAgreement;
    public int num1;
    public int num2;
    public string myString = "Cow";
    public string username;
    public int num3;
    public int num4;
    
    // Use this for initialization
	void Start () {

        //if and else clauses will ALWAYS be opposite; you cannot have an else clause without an if statement
        //a statement is a block of code or a single line of code - the else CLAUSE means it's part of a statement but dependent upon the statement 
        if (myBool)
        {
            print(true);
        }
        else
        {
            print(false);
        }
        //if there are more than 2 outcomes, do NOT use an if statement
        if (password == "OU812" && userAgreement)//|| means "or" - if statements are binary (T/F) if there is more than one possible outcome or more than a T/F outcome, you should not be using an if statement, you should be using a switch or a loop
        {
            print("Correct");
        }  
        else
        {
            print("Incorrect");
        }   
        
        if (num1 + num2 == 5)
        {
            print(true);
        }	
        else
        {
            print(false);
        }

        if (myString == "Cow")
        {
            print(true);
        }
        else
        {
            print(false);
        }
        if (username == "emily")
        {
            print("Correct");
        }
        else
        {
            print("Incorrect");
        }
        if (num3 - num3 == 18)
        {
            print(true);
        }
        else
        {
            print(false);
        }
	}
}
