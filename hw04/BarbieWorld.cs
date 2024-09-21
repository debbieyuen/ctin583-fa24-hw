using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* TODO: Problem 1: GENERICS SHORT ANSWER QUESTIONS
    * What is Unity's `GetComponent<T>`? Why is it considered a generic method?
    Answer: 
    // "GetComponent<T>" is a method can use to get component of type<T>.
    // Because it can work with any type of T, so you can change to any different data types as you want.
    
    * In generics, there is a particular convention we follow in defining generics. What leter do we use to represent a placeholder type or generic? In generics, what are the naming conventions used if we have more than one parameter?
    Answer:  
    // We use the letter <T> to represent a placeholder type or generic. 
    // If we have more than one parameter, there are several different ways to represent it. The first way is to add number after it like T1, T2, T3, and T4. The another way is to using T as a prefix and add anything after it like TGame, TMachine, and TCode. 
    
    * What does the generic variable do? Why does it end up as the return type and argument type for a method? 
    Answer: 
    // generic variable can be the placeholder for a type. Also can help we to able change in different data types.
    
    * Give a realistic and detailed example of when you would want to use generics in your game. When would type variables be useful?
    Answer: I think when I want to saving or loading system, the generics can be really helpful. 
    // Because when I save or load I need data of different object types so that generics will be really useful, because it can help me to keep my type changing safety. 
    // And generics are really good at building reusable systems.
    
    * What are the performance implications of using generic arrays as opposed to non-generic arrays in C#?
    Answer:
    // Using generic arryas is more flexiable in type difference, but for non-generic arrays need to becareful of the type difference or might lead to errors.
    // Also generic arrays can have better on optimizing the code rather than the non-generic arrays.

    * What does it mean to instantiate? */
    Answer:
    // Instantiate means to create an instance of it. like creating a specific object from a class or template.
public class BarbieWorld<T>
{
    T item; 
    T currentCareer;
    
    /* TODO: Problem 2: BARBIE'S CAREERS: Barbie wears many hats. She is a photographer,
    singer, athlete, painter, musician, rockstar, and much more.
    What is the function below trying to accomplish?
    Answers:
    // The function below is trying to help Barbie to set it current career to new career.

    How are we using the T variable in this case?
    Answers:
    // We are using the T variable to set the different type of Barbie's new Careers.

    Please instantiate an item of this class in  
    your BarbieWalletBalance.cs file in your
    Start() or Update() functions. */
    public void BarbieCareers(T newCareer) {
        currentCareer = newCareer;
    }

    private void Start() {
        item = new T(); 
    }
    

}