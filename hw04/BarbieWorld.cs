using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* TODO: Problem 1: GENERICS SHORT ANSWER QUESTIONS
    * What is Unity's `GetComponent<T>`? Why is it considered a generic method?
    // The GetComponent<T> method is used to find in both built-in types and types created by the programmer. It is considered generic becuase it works with all types. That is to say, that 
    // it can be used with any type of object, for example, a Sphere, a Capsule, a Cube.

    * In generics, there is a particular convention we follow in defining generics. What leter do we use to represent a placeholder type or generic? In generics, what are the naming conventions used if we have more than one parameter? 
    // We use the letter T. If there is more than one parameter, we use T, U, V. Another convention is to use the letter T followed by a description of the type, like TValue or TKey.

    * What does the generic variable do? Why does it end up as the return type and argument type for a method?
    // It is a placeholder for a type that is not specified when the class is defined. This allows use to use the same class with different types.

    * Give a realistic and detailed example of when you would want to use generics in your game. When would type variables be useful?
    // One example is creating a class Enemy that can be used with different types of enemies. For example, we can create a class Enemy<T> that can be used with different types of enemies,
    // like a Zombie or a Ghost. This allows us to use any code that would be repeated for both without having to write it twice or more. 

    * What are the performance implications of using generic arrays as opposed to non-generic arrays in C#?
    // Generic arrays perform better than non-generic arrays because they are type-safe.

    * What does it mean to instantiate? 
    // To create an instance of a class or object, like a prefab for example.
*/

public class BarbieWorld<T>
{
    T item;
    /* TODO: Problem 2: BARBIE'S CAREERS
        * Barbie wears many hats. She is a photographer, singer, athlete, painter, musician, rockstar, and much more. What is the function below trying to accomplish? How are we using the T variable in this case? 
        * Please instantiate an item of this class in your BarbieWalletBalance.cs file in your Start() or Update() functions.
        // The function below is trying to set Barbie's current career to the new career that is passed. We are using the T variable to allow the class to be used with any type.
    */

    public void BarbieCareers(T newCareer)
    {
        currentCareer = newCareer;
    }
}