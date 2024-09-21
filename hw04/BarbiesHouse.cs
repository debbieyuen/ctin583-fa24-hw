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
    List<T> pets;
    List<T> householdItems;
    List<T>  foods;

    void NewPets(T pet){
        pets.add(pet);
    }

    void NewhouseholdItems(T householdItem){
        householdItems.add(householdItem);
    }

    void Newfoods(T food){
        foods.add(food);
    }


}