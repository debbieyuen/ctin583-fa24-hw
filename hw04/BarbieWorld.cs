using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* TODO: Problem 1: GENERICS SHORT ANSWER QUESTIONS
    * What is Unity's `GetComponent<T>`? Why is it considered a generic method?
    * In generics, there is a particular convention we follow in defining generics. What leter do we use to represent a placeholder type or generic? In generics, what are the naming conventions used if we have more than one parameter? 
    * What does the generic variable do? Why does it end up as the return type and argument type for a method? 
    * Give a realistic and detailed example of when you would want to use generics in your game. When would type variables be useful?
    * What are the performance implications of using generic arrays as opposed to non-generic arrays in C#?
    * What does it mean to instantiate? */

   //Unity's GetComponent<T> is a high-level generic method that gets the component of a generic Type.
   //The letter used for Generics is T. If there is more than one generic parameter, we use each subsequent letter from T in alphabetical order <T, U, V>
   //The generic variable is a placeholder for any type the programmer wants to use that code logic for, without having to rewrite the code
    //It also makes sure that the type that you put in is the type that is returned
   
   //One example of using generics in a game is if you want to make an elemental attack. 
   //Generics could be used to apply different types of damage, depending on the Type passed in as an argument

   //Generics arrays in C# are generally more preformant because of its strict rules for being type safe. 
   //In non Generic arrays there can be type conversions, which impact preformance

   //Instantiate essentially means creating something in the game world, whether its a class or a gameobject.
   
   //


public class BarbieWorld<T>
{
    T item; 
    /* TODO: Problem 2: BARBIE'S CAREERS: Barbie wears many hats. She is a photographer,
    singer, athlete, painter, musician, rockstar, and much more.
    What is the function below trying to accomplish?
    How are we using the T variable in this case?
    Please instantiate an item of this class in  
    your BarbieWalletBalance.cs file in your
    Start() or Update() functions. */

    //The method is a generic method that changes barbie's career to that of any type passed in as an argument
    public void BarbieCareers(T newCareer) {
        currentCareer = newCareer;
    }

}