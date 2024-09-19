using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* TODO: Problem 1: GENERICS SHORT ANSWER QUESTIONS
    * What is Unity's `GetComponent<T>`? Why is it considered a generic method?
        GetComponent<T> is a generic that allows you to access components in your class and other classes. 
        It's a generic method because it can handle different types of components and data structures.

    * In generics, there is a particular convention we follow in defining generics. What leter do we use to represent a placeholder type or generic? 
    In generics, what are the naming conventions used if we have more than one parameter? 
        Placeholders usually start with <T> and then progress through the alphabet (T, U, V... etc).
        Multiple parameters can be labeled as <T1, T2, T3, etc>. If the parameters are meaningful, 
        the name of the parameter can be used with "T" in front. For example <TParam, TThis, TThat>

    * What does the generic variable do? Why does it end up as the return type and argument type for a method? 
        The generic variable represents the type being called by the generic method. It ends up as the 
        return and argument type because the generic is using that particular type as the parameter. 

    * Give a realistic and detailed example of when you would want to use generics in your game. When would type variables be useful?
        An example where you might use generics is a movement system that needs to accomodate moving
        both on land and underwater. You could define a generic method to handle movement so that it 
        can use both Vector2 and Vector3 types for the same general movement- 2D on land and 3D underwater. 

    * What are the performance implications of using generic arrays as opposed to non-generic arrays in C#?
        Generic arrays are much better for performance than non-generic arrays. By using generics, 
        you can avoid code reuse and having many separate arrays for your computer to process. 

    * What does it mean to instantiate? 
        Instantiate creates an instance of the called object. In unity, this is often a GameObject that
        gets created or cloned in the game. 
*/

public class BarbieWorld<T>
{
    T item; 
    /* TODO: Problem 2: BARBIE'S CAREERS: Barbie wears many hats. She is a photographer,
    singer, athlete, painter, musician, rockstar, and much more.
    What is the function below trying to accomplish?
        The method BarbieCareers() sets the currentCareer to a new newCareer (of any type) that is used 
        as a parameter of the method. 
    How are we using the T variable in this case?
        The T variable allows different types to be used as arguments in this generic.
    Please instantiate an item of this class in  
    your BarbieWalletBalance.cs file in your
    Start() or Update() functions. */
    public void BarbieCareers(T newCareer) {
        currentCareer = newCareer;
    }
}