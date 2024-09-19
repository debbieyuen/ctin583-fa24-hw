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
        // Problem 2 Instantiate example
        BarbieWorld photographerBarbie = new BarbieCareers("Photographer");

        int[] biggerWallet = BarbieWallet(500, 600);
        Debug.Log(biggerWallet.Length + " " + biggerWallet[0] + " " + biggerWallet[1]);

        GetMoney(500, 600);
    }
    private T BarbieBank<T>(T numOfPennies, T cashAmount, T numOfCreditCards)
    {
        T[] bankArray = new T[]{numOfPennies, cashAmount, numOfCreditCards};
        return bankArray;
    }

    /* TODO: Problem 4: INHERITANCE: SHORT ANSWERS
        * What is the "Protected" access modifier? How does it relate to inheritence and between two classes. 
            Protected is like private, but all child classes can still access the object. 
        * What is MonoBehaviour? Why do Unity C# scripts inherit from MonoBehaviour? Give some examples of Unity functions that come from MonoBehaviour. 
            MonoBehaviour is the base class for components of GameObjects. It contains life cycle functions like Start() and Update().
            Most Unity C# scripts inherit from MonoBehaviour because they are attached to GameObjects as components. 
        * What is multiple inheritance? Can we perform multiple inheritance in C#? Why or why not?
            Multiple inheritance is when a class inherits from more than one base class. C# does not support multiple
            inheritance from classes, but it supports inheritance from multiple interfaces. With interface inheritance, C# can
            support flexible code with minimized reuse while reducing the complexity that comes from class inheritance. 
        * What does "Protected virtual void" mean? When is it needed and what does virtual do in your code?
            "Virtual" allows a subclass to override the method. If you want inheriting classes to use a method from the base 
            class but with a different definition, you can use virtual. Protected means that the method is private but
            accessible to subclasses. Void means the method has no return. 
        * What happens when a constructor in a parent class is called? How do we control which base class contructor is being called?
            When a constructor from the parent class is called, it will fail unless it includes the : parent() syntax.
            By adding the : whatever() extension, we can control which base class is called. 
     */ 
    private void KenWallet<T1, T2>(T1 money, T2 moreMoney) {
        Debug.Log(money.GetType());
        Debug.Log(moreMoney.GetType());
    }
}