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
    T furniture;
    T pets;
    T householdItems; 


    //Furniture 
    public void Furniture(T newFurniture) {
        currentFurniture = newFurniture;
    }

    //Pets  
    public void Pets(T newPet) {
        currentPet = newPet;
    }

    //Household Items
    public void HouseholdItems(T newHouseholdItem) {
        currentHouseholdItem = newHouseholdItem;
    }


    
}