using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* TODO: Problem 5: BARBIES HOUSE
Barbie's House needs to inherit everything from the BarbieWorld class in your
BarbieWorld.cs file. Please modify the BarbieHouse class to inherit from
BarbieWorld and write at least three methods within BarbieHouse representing 
furniture, pets, household items, food, etc. within her house. 
*/ 
public class BarbieHouse : BarbieWorld 
{
    public void Furniture (string furnitureName)
    {
        Debug.Log("Barbie has a " + furnitureName + " in her house.");
    }

    public void Pets (string petName)
    {
        Debug.Log("Barbie has a " + petName + " in her house.");
    }

    public void HouseholdItems (string itemName)
    {
        Debug.Log("Barbie has a " + itemName + " in her house.");
    }
}