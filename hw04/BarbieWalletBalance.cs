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

    private List BarbieBank(int numOfPennies, float cashAmount, int numOfCreditCards){
        List <T> barbieBankStatement = new List<T>();
        barbieBankStatement.add(numOfPennies);
        barbieBankStatement.add(cashAmount);
        barbieBankStatement.add(numOfCreditCards);
        return barbieBankStatement;
    }

    /* TODO: Problem 4: INHERITANCE: SHORT ANSWERS
        * What is the "Protected" access modifier? How does it relate to inheritence and between two classes. 
        Answer:
        // the "Protected" access modifier is to control access to calss members, 
        it can allowed certain child classes only can accessible from certain parents nor the outside of the classes.
        It blocked the certain members can only read by certain classes not all codes.

        * What is MonoBehaviour? Why do Unity C# scripts inherit from MonoBehaviour? Give some examples of Unity functions that come from MonoBehaviour. 
        Answer:
        // In Unity, MonoBehaviour is a class that have lots of core things and methods do with Unity's game engine.
        // For example that MonoBehaviour has lots of built-in methods like Awake(), Start(), and Update(). 
        // And it also allow as to attaching scripte to GameObject to control behaviour.
        
        * What is multiple inheritance? Can we perform multiple inheritance in C#? Why or why not?
        Answer:
        // Multiple inheritance is a concept in object-oriented programming, 
        // it can make the subclass can inherit properties and mothods from several different parent classes at same time.
        // No, C# does not support multiple inheritance. 
        // Becuase C# trying disallows multiple inheritance to aviod complexity and ambiguity that might rise.
        
        * What does "Protected virtual void" mean? When is it needed and what does virtual do in your code?
        Answer:
        // In C# "Protected virtual void" is a combination of the words protected, virtual, and void. 
        // Protected: Means it can only be accessed within the class it is declared in and by subclass classes.
        // Virtual: It can be overridden in a derived class to provide custom functionality.
        // Void: Means it does not return any value.
        
        * What happens when a constructor in a parent class is called? How do we control which base class contructor is being called?
        Answer:
        // The constructor of base class will be executed first,and then the derived class is executed.
        
     */ 
    private void KenWallet<T1, T2>(T1 money, T2 moreMoney) {
        Debug.Log(money.GetType());
        Debug.Log(moreMoney.GetType());
    }
}