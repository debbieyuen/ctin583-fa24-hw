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

    private T[] BarbieBank<T>(T numOfPennies, T cashAmount, T numOfCreditCards) {
        return new T[] {numOfPennies, cashAmount, numOfCreditCards};
    }


    void Start()
    {
        BarbieWorld<int> world = new BarbieWorld<int>;

        int[] biggerWallet = BarbieWallet(500, 600);
        Debug.Log(biggerWallet.Length + " " + biggerWallet[0] + " " + biggerWallet[1]);

        GetMoney(500, 600);
    }

    /* TODO: Problem 4: INHERITANCE: SHORT ANSWERS
        * What is the "Protected" access modifier? How does it relate to inheritence and between two classes. 
        * What is MonoBehaviour? Why do Unity C# scripts inherit from MonoBehaviour? Give some examples of Unity functions that come from MonoBehaviour. 
        * What is multiple inheritance? Can we perform multiple inheritance in C#? Why or why not?
        * What does "Protected virtual void" mean? When is it needed and what does virtual do in your code?
        * What happens when a constructor in a parent class is called? How do we control which base class contructor is being called?
     */ 

     //the protected access modifier works like a private modifier, except it can also be accessed in child classes.
     //It cannot be accessed by classes outside the parent child relationship

     //MonoBehavior is a base class that many unity scripts derive from.
     //it provides unity's essential methods like Start(), Update() and FixedUpdate() 

     //Multiple inheritance means that a class can inherit from multiple parents
     //Multiple inheritance isn't allowed in C# because it can lead to ambiguity of class attributes (e.g. duplicate methods in different parent classes)

     //protected: can be accessed within the class and its children, but nowhere else
     //virutal: can be overrided within child classes
     //void: this attribute has no return type

     //When a constructor of a parent class is called, the parent class's logic is instantiated before that of the child.
     //you can control which base class constructor is called by passing in various arguments that differentiate between constructors.

    private void KenWallet<T1, T2>(T1 money, T2 moreMoney) {
        Debug.Log(money.GetType());
        Debug.Log(moreMoney.GetType());
    }
}