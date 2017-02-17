using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{

    //loops are where you compare data
    //an array is a container of variables 

    public string[] animals;

    //always do data type first and then the identifier (the name)
    public string animal = "Wolf";

    // Use this for initialization
    void Start()
    {
        foreach (string animalInAnimals in animals)
        {
            if (animal == animalInAnimals)
            {
                print("I have a match, it is " + animalInAnimals);
            }
            else
            {
                print(animalInAnimals + " is not a match");
            }
        }
    }
}

