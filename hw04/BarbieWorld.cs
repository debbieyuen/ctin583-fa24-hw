using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* TODO: Problem 1: GENERICS SHORT ANSWER QUESTIONS
    * What is Unity's `GetComponent<T>`? Why is it considered a generic method?
 * It is a method used to retrieve a component of a specified type T from a game object.
 * It is considered a generic method because it can operate on any type T, where T is a placeholder for the actual type you want to retrieve. 
    * In generics, there is a particular convention we follow in defining generics. What leter do we use to represent a placeholder type or generic? In generics, what are the naming conventions used if we have more than one parameter?
 * We use T to represent generics. We can use T1, T2 to represent multiple generics.
    * What does the generic variable do? Why does it end up as the return type and argument type for a method?
 * The generic variable acts as a placeholder for a concrete type that will be specified when the method or class is used.
 * The generic variable ends up as the return type or argument type because it defines the type of data that the method will accept and return. 
    * Give a realistic and detailed example of when you would want to use generics in your game. When would type variables be useful?
 * For example, we can have different types of bars such as health, mana or stamina.We can use GetBar<T> to retrieve the bar type.
    * What are the performance implications of using generic arrays as opposed to non-generic arrays in C#?
 * In general, using generic arrays is preferable because they provide both type safety and better performance.
    * What does it mean to instantiate?
 * It means to create an instance of an object*/
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
    // This function is defining the Barbie's current career. I don't know how to solve the second part.
}