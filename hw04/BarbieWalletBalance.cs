using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbieBank : MonoBehaviour
{
    

    // Start is called before the first frame update

    /* TODO: Problem 3: BARBIE'S BANK
    Convert the following function to a generic if needed. 
    Then, write a private generic function named BarbieBank. 
    BarbieBank should take in the parameters: numOfPennies, cashAmount, and numOfCreditCards
    Have the function return a new generic array with the correct parameters. 
    */

    void Start()
    {
        int[] biggerWallet = BarbieWallet(500, 600);
        Debug.Log(biggerWallet.Length + " " + biggerWallet[0] + " " + biggerWallet[1]);

        GetMoney(500, 600);
        
        
    }

    private T[] BarbieBank<T1, T2, T3>(T1 numOfPennies, T2 cashAmount, T3 numOfCreditCards)
    {
        return new T[] { numOfPennies, cashAmount, numOfCreditCards };
    }

    /* TODO: Problem 4: INHERITANCE: SHORT ANSWERS
        * What is the "Protected" access modifier? How does it relate to inheritence and between two classes.
     * "Protected" means accessible within its own class, but not from other classes or instances.
        * What is MonoBehaviour? Why do Unity C# scripts inherit from MonoBehaviour? Give some examples of Unity functions that come from MonoBehaviour.
     * It provides essential functionalities needed for interacting with the Unity game engine.
     * It has functions such as Start(),Update() and Instantiate, etc.
        * What is multiple inheritance? Can we perform multiple inheritance in C#? Why or why not?
     * It's when a class inherit from more than one base class. We can not because C# doesn't allow it.
        * What does "Protected virtual void" mean? When is it needed and what does virtual do in your code?
     * virtual: Marks a method as overridable. Protected virtual void is typically used when you want a base class to define a method, but allow derived classes to override it.
        * What happens when a constructor in a parent class is called? How do we control which base class contructor is being called?
     * Constructor of the base class is automatically called first to initialize the base class part of the object. You can use the base keyword to specify the base class constructor to call, passing in the required parameters.
     */ 
    private void KenWallet<T1, T2>(T1 money, T2 moreMoney) {
        Debug.Log(money.GetType());
        Debug.Log(moreMoney.GetType());
    }
}