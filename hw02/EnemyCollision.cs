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
    
    // TODO: Problem 7: Why did I not include the words public or private here?
    // What does it mean when I only write void (Movement)? What does void mean?
    void Movement () // "void" is used to specify a type of function that does NOT return a value
    // public objects can be accessed from anywhere, but private objects can only be accessed from within the same class

    {
        // TODO: Problem 8: Please explain what the next 4 lines mean.
        // What is Input.GetAxis, transform.Translate, and transform.Rotate? 
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime; // this line defines a variable as the product of speed and vertical input position, all over time
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime; // this line defines a variable as the product of speed and horizontal input position, all over time
        
        transform.Translate(Vector3.forward * forwardMovement); // this line moves (translates) the object forward according to the vertical variable
        transform.Rotate(Vector3.up * turnMovement); // this line turns (rotates) the object according to the horizontal variable
    }


    void Shoot ()
    {
        // TODO: Problem 9: Looking at this code, is this code using Unity's Old or New 
        // Input System? Please describe what Instantiate is doing in this if statement.

        // This code looks like Unity's old input system because it only works with a specific input. 
        if(Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed); // "Instantiate" creates a copy of the object (bullet), in this case it also adds force/direction to the bullet
            myStuff.bullets--; 
        }
    }

    /* TODO: Problem 10: In our game, we want our enemy to alternate weapons every couple of frames.
    However, also would like our enemy to lose access to their weapons when they are frozen/disabled.
    First, let's define a public class named Weapon. In the class, define 3 int variables for arrow, sword, and rocket.
    
    
    Outside of our Weapon class, we would want to define an IEnumerator function. 
    Then in our class, write a for loop that loops between the arrow, sword, and rocket. 
    Use the WaitForSeconds function to tell it to switch weapons every 5 seconds. 

    Remember to call your Coroutine.
    */ 

    // I'm really not sure about the code below (actually I'm sure there's a better way if it even works)
    public class Weapon
    {
        int arrow = 0;
        int sword = 1;
        int rocket = 2;

        for (int i = 0, i < 3, int++)
        {
            Start Coroutine(SwitchWeapon());
            if i = 0
            {
                return arrow;
            } 
            elseif i = 1
            {
                return sword;
            }
            elseif i = 2
            {
                return rocket;
            }
        }
    }

    IEnumerator SwitchWeapon()
    {

        yield return new WaitForSeconds(5);
    }
}