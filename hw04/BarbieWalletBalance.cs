using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbieBank : MonoBehaviour
{
    BarbieWorld<string> barbieWorld; 
    // Start is called before the first frame update

    /* TODO: Problem 3: BARBIE'S BANK
    Convert the following function to a generic if needed. 
    Then, write a private generic function named BarbieBank. 
    BarbieBank should take in the parameters: numOfPennies, cashAmount, and numOfCreditCards
    Have the function return a new generic array with the correct parameters. 
    */
    void Start()
    {
        barbieWorld = new BarbieWorld<string>();
        barbieWorld.BarbieCareers("Photographer");

        barbieHouse.DisplayFurniture();
        barbieHouse.ShowPets();
        barbieHouse.ShowFood();
        
        int[] biggerWallet = BarbieWallet(500, 600);
        Debug.Log(biggerWallet.Length + " " + biggerWallet[0] + " " + biggerWallet[1]);

        GetMoney(500, 600);
    }
    private T[] BarbieWallet<T>(T money1, T money2)
    {
        return new T[] { money1, money2 };
    }

    private T[] BarbieBank<T>(T numOfPennies, T cashAmount, T numOfCreditCards)
    {
        return new T[] { numOfPennies, cashAmount, numOfCreditCards };
    }

    void Update()
    {
        // On pressing the C key, change Barbie's career to Rockstar
        if (Input.GetKeyDown(KeyCode.C))
        {
            barbieWorld.BarbieCareers("Rockstar");
        }

        // On pressing the P key, change Barbie's career to Painter
        if (Input.GetKeyDown(KeyCode.P))
        {
            barbieWorld.BarbieCareers("Painter");
        }
    }

  
    

    /* TODO: Problem 4: INHERITANCE: SHORT ANSWERS
        * What is the "Protected" access modifier? How does it relate to inheritence and between two classes.
            *The "Protected" access modifier allows access to class members within the same class, its subclasses.
             Regarding inheritance: Subclasses can access protected members of their parent class. It enables parent classes to share certain members with child classes while keeping them hidden from external code.
             Between two classes: If Class B inherits from Class A, it can access Class A's protected members.
        * What is MonoBehaviour? Why do Unity C# scripts inherit from MonoBehaviour? Give some examples of Unity functions that come from MonoBehaviour. 
            *MonoBehaviour is a base class for Unity scripts which allows scripts to interact with Unity's event system and game loop
            * Unity C# scripts inherit from MonoBehaviour because they can access to Unity-specific events and functions, integrate with Unity's component system and have ability to attach scripts to GameObjects
              Automatic script lifecycle management
            * Example: Start(); Update(); FixedUpdate()
        * What is multiple inheritance? Can we perform multiple inheritance in C#? Why or why not?
            *Multiple Inheritance allows a class to inherit properties and methods from multiple parent classes and can lead to more complex class hierarchies and potential naming conflicts
            *We cannot perform multiple inheritance in C# to prevent conflicts when two base classes have methods with the same name
        * What does "Protected virtual void" mean? When is it needed and what does virtual do in your code?
            *Protected: Access modifier that allows the method to be accessed within the same class and its derived classes.
            *Virtual: Keyword that enables the method to be overridden in derived classes.
            *Void: Return type indicating the method doesn't return a value.
        * What happens when a constructor in a parent class is called? How do we control which base class contructor is being called?
            *Firstly, the child class constructor is invoked. Secondly, before executing the child constructor's body, the parent constructor is called.
            *Thirdly, the parent constructor initializes its own fields and performs its setup. Fourthly, control returns to the child constructor, which then initializes its fields and completes its setup.
            * Use the base keyword to control.
     */ 
    private void KenWallet<T1, T2>(T1 money, T2 moreMoney) {
        Debug.Log(money.GetType());
        Debug.Log(moreMoney.GetType());
    }
}
