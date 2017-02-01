using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syntax : MonoBehaviour {

    // Variable = changeable pieces of data
    // String is the data type - "a string of words, data, etc." - STRINGS MUST HAVE QUOTATIONS - strings start with a lowercase, but are camel cased
    // Identifiers can only be 1 word
    // Functions start with an upper case
    // Something you CANNOT do with strings or variables - you cannot start any identifies with a numeric value (ie. 1String)
    public string myString = "10";
    public string myOtherString = "1";
    // int = a whole number; (1.0 is not an int because there is a decimal - it is now a floating value)
    public int myInt = 1;
    // Floats may have decimals; in C# you have to put an "f" after the value; a floating point value; if you DON'T need a float, use an int
    public float myFloat = 1.2f;
    // Bools are just true or false, there is no other possible answer (ie. a light switch - can only be on or off)
    public bool myBool = false; 

    // Don't put parentheses in your class - classes do not accept parameters
	// Use this for initialization
	void Start () {
        print("Hello World"); //put a semi colon after every single line of code
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
