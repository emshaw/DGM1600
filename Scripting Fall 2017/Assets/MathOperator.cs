using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperator : MonoBehaviour {

    //+ is used for addition, - is used for subtraction, / is used for division, * is used for multiplication, % is used for remainder
    public int addition = 12 + 4;
    public int subtraction = 12 - 4;
    //if you want the result for division not to round, FORCE it to be a float (add decimals and an "f")
    //ie. not rounding would be "public float division = 5 / 2;"
    public float division = 5.0f / 2.0f;
    public int multiplication = 5 * 2;
    public int remainder = 7 % 2;

	// Use this for initialization
	void Start () {
        addition += 9;//+= means add to
        subtraction -= 10;//-= means subtract from (it'll take the value from the subtraction above and then subtract 10 more -- 12 - 4 - 10 
        addition += 3;
        addition = 1;//this scraps everything else! = is assinging a 1 to addition; LINE ORDER ALWAYS READS FROM THE TOP DOWN
        subtraction -= 5; 
	}
}
