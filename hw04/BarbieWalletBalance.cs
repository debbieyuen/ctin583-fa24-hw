using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbieBank : MonoBehaviour
{

    BarbieWorld<string> barbieCareer;

    /* TODO: Problem 3: BARBIE'S BANK
    Convert the following function to a generic if needed. 
    Then, write a private generic function named BarbieBank. 
    BarbieBank should take in the parameters: numOfPennies, cashAmount, and numOfCreditCards
    Have the function return a new generic array with the correct parameters. 
    */
    private T[] BarbieBank<T>(T numOfPennies, T cashAmount, T numOfCreditCards)
    {
        return new T[] { numOfPennies, cashAmount, numOfCreditCards };
    }

    void Start()
    {
        barbieCareer = new BarbieWorld<string>("Photographer");

        int[] biggerWallet = BarbieWallet(500, 600);
        Debug.Log(biggerWallet.Length + " " + biggerWallet[0] + " " + biggerWallet[1]);

        GetMoney(500, 600);
    }

    /* TODO: Problem 4: INHERITANCE: SHORT ANSWERS
        * What is the "Protected" access modifier? How does it relate to inheritence and between two classes. 
        // "Protected" is an access modifier, similar to private or public, that allows a member (like a variable or method) to be accessed witihin its own class
        // and any subclasses that inherit from it. 

        * What is MonoBehaviour? Why do Unity C# scripts inherit from MonoBehaviour? Give some examples of Unity functions that come from MonoBehaviour.
        // MonoBehaviour is the base class from which every Unity script derives. It allows the script to interact with the Unity engine, enabling behaviors like
        // interacting with physics and recieving input. Examples include Start(), Update(), and OnCollisionEnter().

        * What is multiple inheritance? Can we perform multiple inheritance in C#? Why or why not?
        // Multiple inheritance is when a class inherits from more than one class. This allows a child class to inherit from multiple parent classes. C# does not support
        // multiple inheritance because it can lead to ambiguity and other issues.

        * What does "Protected virtual void" mean? When is it needed and what does virtual do in your code?
        // Protected = method can only be accessed within the class and its subclasses. Virtual = method can be overridden in a subclass. Void = method does not return a value.
        // So this means that the method does not return any value, can only be accessed within the class and its subclasses, and can be overridden in a subclass. When you mark 
        // a method as virtual, you are signaling that it is intended to be modified by subclasses.

        * What happens when a constructor in a parent class is called? How do we control which base class contructor is being called?
        // When an object is instantiated, the constructor of the parent class is called first. We can control which base class constructor is called by using the base keyword.
     */
    private void KenWallet<T1, T2>(T1 money, T2 moreMoney)
    {
        Debug.Log(money.GetType());
        Debug.Log(moreMoney.GetType());
    }
}