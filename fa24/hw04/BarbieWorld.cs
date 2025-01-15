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
    public void BarbieCareers(T newCareer) {
        currentCareer = newCareer;
    }
}