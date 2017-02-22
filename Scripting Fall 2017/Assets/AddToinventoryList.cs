using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToinventoryList : MonoBehaviour
{

    public Lists myInventory;
    public string myWeapon;
    

    public void AddToList()
    {
        myInventory.myWeaponList.Add(myWeapon);
    }
}