using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* TODO: Problem 5: BARBIES HOUSE
Barbie's House needs to inherit everything from the BarbieWorld class in your
BarbieWorld.cs file. Please modify the BarbieHouse class to inherit from
BarbieWorld and write at least three methods within BarbieHouse representing 
furniture, pets, household items, food, etc. within her house. 
*/ 
public class BarbieHouse : BarbieWorld<string>
{
    public void ExamineLivingRoom() {
        Debug.Log("Barbie's house has a couch, a coffee table, and a TV");


    }

    public void CookHabachi<T>(T habachiType, T cookTime) {
        Debug.Log("Barbie made" + habachiType + "in" + cookTime + "minutes");
    }

    public void PlayWithPet<T>(T petType) {
        Debug.Log("Barbie played with a" + petType);
    }
}