using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//PROBLEM: List with 4 elements, Create Loop, Check if an element of list is "Cat," Print that element

public class InClass : MonoBehaviour {

    public List<string> myElements;
    public string element = "Cat";
    
    // Use this for initialization
	public void Start () {
        foreach (string item in myElements)
        {
            if (item == "Cat")
            {
                print(item);
            }
        }
	}
 }
