using System.Collections;
using System.Collections.Generic;
using System.Random;
using UnityEngine;

/* TODO: Problem 5: BARBIES HOUSE
Barbie's House needs to inherit everything from the BarbieWorld class in your
BarbieWorld.cs file. Please modify the BarbieHouse class to inherit from
BarbieWorld and write at least three methods within BarbieHouse representing 
furniture, pets, household items, food, etc. within her house. 
*/ 
public class BarbieHouse : BarbieWorld
{

    Random rnd = new Random();
    List<string> barbiePets = new List<string> {"cat", "dog"};
    List<string> barbieFoods = new List<string> {"ice cream", "candy", "sandwich"};
    
    private void furniture(int numChairs)
    {
        Debug.Log("Barbie owns " + numChairs + " chairs.");
    }

    private List pets(string pet)
    {
        barbiePets.Add(pet);
        return barbiePets;
    }

    private void food()
    {
        string foodToday = rnd.Next(barbieFoods.Count);
        Debug.Log("Barbie ate " + foodToday + " today!");
    }
}