using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{

    //lists are dynamic, arrays are constant
    public string myWeapon;
    public List<string> myWeaponList;
    public string[] myWeaponArray;//this type of array can't be modified 

    private void Start()
    {
        myWeaponList.Add("Sword");
        myWeaponList.Remove("Gun");
        myWeaponList.Add("Machete");
        myWeaponList.RemoveAt(1);//removing from Element 1 on game play screen on unity]
        myWeaponList.Add("Light Saber");

    }

    public void AddToList()
    {
        myWeaponList.Add(myWeapon);
    }
}


