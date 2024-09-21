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

        //Question 2- Instantiate a new career for Barbie 
        BarbieWorld<string> barbieWorld = new BarbieWorld<string>();
        barbieWorld.BarbieCareers("GameDesigner");

    //Problem 3
        // Convert the existing function to a generic array 
        var biggerWallet = BarbieWallet(500, 600);
        Debug.Log(biggerWallet.Length + " " + biggerWallet[0] + " " + biggerWallet[1]);

        GetMoney(500, 600);


        //add the BarbieBank function 
        var bankArray = BarbieBank(500, 600, 3);
        Debug.Log(bankArray.Length + " " + bankArray[0] + " " + bankArray[1] + " " + bankArray[2]);

      
    }

    // Generic function for BarbieWallet
    private T[] BarbieWallet<T>(T numOfPennies, T cashAmount)
    {
        return new T[] { numOfPennies, cashAmount };
    }

    // BarbieBank generic function
    private T[] BarbieBank<T>(T numOfPennies, T cashAmount, T numOfCreditCards)
    {
        return new T[] { numOfPennies, cashAmount, numOfCreditCards };
    }

    //Get Money function 
    void GetMoney(int numOfPennies, int cashAmount)
    {
        
    }



   

    /* TODO: Problem 4: INHERITANCE: SHORT ANSWERS
        * What is the "Protected" access modifier? How does it relate to inheritence and between two classes. 
        * What is MonoBehaviour? Why do Unity C# scripts inherit from MonoBehaviour? Give some examples of Unity functions that come from MonoBehaviour. 
        * What is multiple inheritance? Can we perform multiple inheritance in C#? Why or why not?
        * What does "Protected virtual void" mean? When is it needed and what does virtual do in your code?
        * What happens when a constructor in a parent class is called? How do we control which base class contructor is being called?
     */ 
    private void KenWallet<T1, T2>(T1 money, T2 moreMoney) {
        Debug.Log(money.GetType());
        Debug.Log(moreMoney.GetType());
    }
}

//The "Proteced" access modifier helps with inheritance. Since inheritance can get out of hand, the protected access modifier allows us to control what is inherited, by only allowing the child class to access the parent class.
//Monobehaviour is the default base class for Unity Scripts. Start and Update are Monobehaviour functions.
//When a class can inherit multiple classes. C# doesn't support it because it can get out of hand quickly.
//Protected means that the method can only be accessed by it's class and derived class. Virtual means that the method can be overriden in derived classes. So, protected virtual void means that the method can be overriden in derived classes.
//When the parent class is called in a constructor- the base class is called first and then the derived class. We can control which base class constructor is being called by using the base keyword. ie public class BarbieBank : MonoBehaviour above is calling the Monobehaviour base class.