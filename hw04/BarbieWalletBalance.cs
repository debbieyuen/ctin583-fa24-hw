using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbieWalletBalance : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        int[] biggerWallet = BarbieBank(500, 600);
        Debug.Log(biggerWallet.Length + " " + biggerWallet[0] + " " + biggerWallet[1]);

        GetMoney(500, 600);
    }

    // TODO: Problem 1: Barbie's Wallet
    // Convert the following GetMoney( ) function to a generic.
    private int[] BarbieBank(int numOfPennies, int cashAmount, int numOfCreditCards) {
        return new int[] {numOfPennies, cashAmount, numOfCreditCards};
    }

    // TODO: Problem 2: Ken's Wallet
    //  What if we need more money? Barbies Bank went out. 
    private void KenBank<T1, T2>(T1 money, T2 moreMoney) {
        Debug.Log(money.GetType());
        Debug.Log(moreMoney.GetType());
    }
}