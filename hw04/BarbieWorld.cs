using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* TODO: Problem 1: GENERICS SHORT ANSWER QUESTIONS
    * What is Unity's `GetComponent<T>`? Why is it considered a generic method?
       *A method used to retrieve a component of type T attached to a GameObject. And T is a type parameter representing any component type (e.g., Rigidbody, Collider, custom scripts)
       *Because it uses a type parameter T, allowing it to work with any component type. And it can be used to get any type of component without creating separate methods for each type.
    * In generics, there is a particular convention we follow in defining generics. What leter do we use to represent a placeholder type or generic? In generics, what are the naming conventions used if we have more than one parameter? 
       *Leter T, U, V; TKey and TValue
    * What does the generic variable do? Why does it end up as the return type and argument type for a method? 
       * The generic variable (such as T) acts as a placeholder for a type that gets specified when the class or method is instantiated or invoked. 
    * Give a realistic and detailed example of when you would want to use generics in your game. When would type variables be useful?
       *a game where you need to handle a variety of collectible items, like weapons, potions, or quest items. Each type of item shares some common behavior, but you want to ensure type safety while being able to create collections of any item type.
    * What are the performance implications of using generic arrays as opposed to non-generic arrays in C#?
       *Generic Arrays in C# are generally avoided because arrays are covariant (e.g., object[] can hold string[]), but generics enforce strict type safety. 
    * What does it mean to instantiate?
       *means creating a concrete instance of a class or a data structure based on a template (like a class or a generic class).   
   */
public class BarbieWorld<T>
{
    T currentCareer; 
    /* TODO: Problem 2: BARBIE'S CAREERS: Barbie wears many hats. She is a photographer,
    singer, athlete, painter, musician, rockstar, and much more.
    What is the function below trying to accomplish?
    How are we using the T variable in this case?
    Please instantiate an item of this class in  
    your BarbieWalletBalance.cs file in your
    Start() or Update() functions. */
  
    public void BarbieCareers(T newCareer) {
        currentCareer = newCareer;
        Debug.Log("Barbie's new career is: "+ currentCareer.ToString());
    }
}
