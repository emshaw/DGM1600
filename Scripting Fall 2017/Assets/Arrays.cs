using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

    // Use this for initialization
    void Start() { }

    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[2];

            names[0] = "John Doe";
            names[1] = "Jane Doe";

            foreach (string s in names)
                System.Console.WriteLine(s);

            System.Console.ReadLine();
        }
    }

    
}
	
