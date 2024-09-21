using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* TODO: Problem 5: BARBIES HOUSE
Barbie's House needs to inherit everything from the BarbieWorld class in your
BarbieWorld.cs file. Please modify the BarbieHouse class to inherit from
BarbieWorld and write at least three methods within BarbieHouse representing 
furniture, pets, household items, food, etc. within her house. 
*/ 
public class BarbieHouse : MonoBehaviour
{
     public void DisplayFurniture()
    {
        Debug.Log("Barbie has a couch and a bed.");
    }

    // Method to represent Barbie's pets
    public void ShowPets()
    {
        Debug.Log("Barbie has a dog.");
    }

    // Method to represent food items in Barbie's kitchen
    public void ShowFood()
    {
        Debug.Log("Barbie's fridge is stocked with salads.");
    }
}
