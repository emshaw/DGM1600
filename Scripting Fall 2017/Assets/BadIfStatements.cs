using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadIfStatements : MonoBehaviour {


    public string animal = "Cat";
    
    // Use this for initialization
	void Start () {
        //Copy and pasting code is BAD!!! code should not all look the same
        //This code is technically not wrong, it's just super annoying - bad form
        if (animal == "Cat")
        {
            print("Cat");
        }

        if (animal == "Dog")
        {
            print("Dog");
        }

        if (animal == "Bird")
        {
            print("Bird");
        }

        if (animal == "Elephant")
        {
            print("Elephant");
        }

        if (animal == "Mole")
        {
            print("Mole");
        }
    }
	
	
}
