using UnityEngine;
using System.Collections;

public class LogicalOperators : MonoBehaviour {

    public string string1;
    public string string2;
    public string cat;
    public string dog;
    public string michaelPhelps;
    public string ryanLochte;

    // Use this for initialization
    public void OnButtonClick() {
        if (string1 == "Thing 1" && string2 == "Thing 2")//if string 1 is equal to thing 1 AND string 2 is equal to thing 2
        {
            print("These things are quite tame.");
        }

        if (string1 == "Thing 1" || string2 == "Thing 2")//if string 1 is equal to thing 1 OR string 2 is equal to thing 2
        {
            print("It's fun to have fun if you know what to do.");
        }

        if (string1 != "Thing 1" && string2 != "Thing 2")//if string 1 is NOT equal to thing 1 AND string 2 is NOT equal to thing 2
        {
            print("Oh what a shame, what a shame, what a shame");
        }

        if (cat == "Meow" && dog == "Woof")
        {
            print("Cats go meow and dogs go woof.");
        }

        if (cat == "Meow" || dog == "Woof")
        {
            print("Either cats meow or dogs woof.");
        }

        if (cat != "Meow" && dog != "Woof")
        {
            print("These animals are not normal.");
        }

        if (michaelPhelps == "Winner" && ryanLochte == "Loser")
        {
            print("Michael Phelps is the greatest of all time.");
        }

        if (michaelPhelps == "Winner" || ryanLochte == "Loser")
        {
            print("Either Michael Phelps wins or Michael Phelps wins.");
        }
        if (michaelPhelps != "Winner" && ryanLochte != "Loser")
        {
            print("CRIKEY! Michael Phelps lost!");
        } 
        
        if (michaelPhelps != "Winner")
        {
            print("What is this world coming to?");
        }	
	}
}
