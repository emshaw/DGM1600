using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ForeachLoops : MonoBehaviour {

    public List<GameObject> powerUpList;
    public List<GameObject> capsuleList;
    public List<GameObject> sphereList;
    public List<GameObject> cubeList;
    
    // Use this for initialization
	public void CheckData ()
    {
        foreach (GameObject item in powerUpList)
        {
            switch (item.name)
            {
                case "Cube":
                    cubeList.Add(item);
                    break;
                case "Sphere":
                    sphereList.Add(item);
                    break;
                case "Capsule":
                    capsuleList.Add(item);
                    break;
            }
        }
    }	
}

namespace foreach_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[5];//declaring array

            //storing value in array element
            arr[0] = "Steven";
            arr[1] = "Clark";
            arr[2] = "Mark";
            arr[3] = "Thompson";
            arr[4] = "John";

            //retrieving value using foreach loop
            foreach (string name in arr)
            {
                System.Console.WriteLine("Hello" + name);
            }
            System.Console.ReadLine();
        }
    }
}

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = new int[4];
            intarray[0] = 10;
            intarray[1] = 20;
            intarray[2] = 30;
            intarray[3] = 40;

            foreach (int i in intarray)
            {
                System.Console.WriteLine(i);//C# foreach example
            }

            System.Console.ReadLine();
        }
    }
}

class Program
{
    static void Main()
    {
        string[] pets = { "dog", "cat", "bird" };//loop with the foreach keyword
        
        foreach (string value in pets)
        {
            System.Console.WriteLine(value);
        }
    }
}
	
