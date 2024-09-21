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


    //Answers:
    //GetComponent<T> is a generic method that can get any type of component, like a rigidbody or script. It's generic because it can get any type of component.
    //We use T as a placeholder or type. If we have more than one parameter, we use T,U,V, etc.
    //Genetic variables let us use any type of data in a method. It's the return type and argument type so that it can be reused with any type of data. 
    //We used it in the Kitchen Chaos tutorial to clean up multiple lines of code that were all returning the same variable. Another example would be setting up an inventory system where you have multiple types of items. With a generic, we could access all of these items with one method. It's helpful to reduce the amount of code.
    //Generic arrays are faster than non-generic arrays, since non-generic arrays have to box and unbox data. 
    //Instantiate means that you're creating an instance of a class or object. 
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
    
    //Answers: 
    //The function is setting Barbie's current career equal to her new career. We're using the T variable so that we can set any type of career for Barbie.