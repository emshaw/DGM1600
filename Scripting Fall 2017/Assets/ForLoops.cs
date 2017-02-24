using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ForLoops : MonoBehaviour {

    public List<string> cars;
    
    
    // Use this for initialization
	void Start () {
        //a for loop has an iterator - an iterator is used to count - usually started at 0
        for (int i = 0; i < cars.Count; i++)//i++ adds one because ++ means add 1 - for lists, it's ____.count, for arrays, it's ____.length
        {
            print(cars[i]);//use i because that's the indexer that is being used earlier
        }
    }
}
