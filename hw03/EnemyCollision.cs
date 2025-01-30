using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



//---------------------------------------------------------PROBLEM 7----------------------------------------------------------------//

    // TODO: Problem 7: Why did I not include the words public or private here?
    // What does it mean when I only write void (Movement)? What does void mean? 


    // If I didn't use public or private, it defaults to private and private can only be used inside the class. Public means you can acessed from other classes.
    // Void means no return values, but only a movement.



//---------------------------------------------------------PROBLEM 8----------------------------------------------------------------//

    void Movement ()
    {
        // TODO: Problem 8: Please explain what the next 4 lines mean.
        // What is Input.GetAxis, transform.Translate, and transform.Rotate? 
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        //This line get input of the player moving vertically (up and down). Speed and Time.deltaTime make sure the movement is smooth.
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        //This line get input of the player moving horizontally (left and right). Speed and Time.deltaTime make sure the movement is smooth.


        transform.Translate(Vector3.forward * forwardMovement);
        //The line moves object forward or backward.

        transform.Rotate(Vector3.up * turnMovement);
        //The line rotates the object left or right.

    }



//---------------------------------------------------------PROBLEM 9----------------------------------------------------------------//

    void Shoot ()
    {
        // TODO: Problem 9: Looking at this code, is this code using Unity's Old or New 
        // Input System? Please describe what Instantiate is doing in this if statement.
        if(Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
        // This is Unity's Old. If it's Unity's New, it will use InputAction.
        // The if statement is checking if the player is pressing the "Fire" button.
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            //Instantiate is creating a new bullet in the game and shoot in the right direction, and bulletPrefab is a ready object. Rigidbody means the bullet can effect as a physcial object in the game.
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            // Make the bullet goes forward with speed.
            myStuff.bullets--;
        }
    }


//---------------------------------------------------------PROBLEM 10----------------------------------------------------------------//

    /* TODO: Problem 10: In our game, we want our enemy to alternate weapons every couple of frames.
    However, also would like our enemy to lose access to their weapons when they are frozen/disabled.
    First, let's define a public class named Weapon. In the class, define 3 int variables for arrow, sword, and rocket.
    

    Outside of our Weapon class, we would want to define an IEnumerator function. 
    Then in our class, write a for loop that loops between the arrow, sword, and rocket. 
    Use the WaitForSeconds function to tell it to switch weapons every 5 seconds. 

    Remember to call your Coroutine.
    */ 

using UnityEngine;
using System.Collections;

public class Weapon
{
    public int arrow = 1;
    public int sword = 2;
    public int rocket = 3;
}

public class Enemy : MonoBehaviour
{
    public Weapon currentWeapon = new Weapon();  
    private bool isFrozen = false; 

    void Start()
    {
        StartCoroutine(SwitchWeapons());
    }

IEnumerator SwitchWeapons()
{
    int[] weapons = { currentWeapon.arrow, currentWeapon.sword, currentWeapon.rocket };
    int index = 0;

    while (true)
    {
        if (isFrozen)
        {
            Debug.Log("Enemy is frozen! Cannot switch weapons.");
        }
        else
        {
            int selectedWeapon = weapons[index]; 
            Debug.Log("Enemy switched to weapon: " + selectedWeapon);

            index = (index + 1) % weapons.Length; 
        }

        yield return new WaitForSeconds(5f);  
    }
}

public void FreezeEnemy()
{
    if (!isFrozen) 
    {
        isFrozen = true;
        Debug.Log("The Enemy is frozen now.")
    }

}

public void UnfreezeEnemy()
{
    if (isFrozen)  
    {
        isFrozen = false;
        Debug.Log("Enemy is unfrozen now.");
    }

}

}




}