using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Problem 10 - Call the Coroutine here
        StartCoroutine(SwitchWeapons());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // TODO: Problem 7: Why did I not include the words public or private here?
    // What does it mean when I only write void (Movement)? What does void mean?

    // Excluding public or private means that the function defaults to private. void (Movement) means that the function is private, and void means that the function
    // does not return a value.
    void Movement ()
    {
        // TODO: Problem 8: Please explain what the next 4 lines mean.
        // What is Input.GetAxis, transform.Translate, and transform.Rotate? 

        // Input.GetAxis returns a value of -1, 0, or 1, which determines the direction of the player's movement based on the input, or if there is no input.
        // transform.Translate moves the player's position based on the input, and transform.Rotate turns the player in the game world based on the input.
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        
        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }
    
    
    void Shoot ()
    {
        // TODO: Problem 9: Looking at this code, is this code using Unity's Old or New 
        // Input System? Please describe what Instantiate is doing in this if statement.

        // Since the new input system imports the UnityEngine.InputSystem namespace, this code is using Unity's old input system. Instantiate 
        // creates a new instance of the bullet prefab at the fire position and adds a force to the bullet instance in the forward direction.
        if(Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            myStuff.bullets--;
        }
    }

    /* TODO: Problem 10: In our game, we want our enemy to alternate weapons every couple of frames.
    However, also would like our enemy to lose access to their weapons when they are frozen/disabled.
    First, let's define a public class named Weapon. In the class, define 3 int variables for arrow, sword, and rocket.

    Outside of our Weapon class, we would want to define an IEnumera for loop that loops between the arrowator function. 
    Then in our class, write , sword, and rocket. 
    Use the WaitForSeconds function to tell it to switch weapons every 5 seconds. 

    Remember to call your Coroutine.
    */ 

    public class Weapon
    {
        public int arrow = 1;
        public int sword = 0;
        public int rocket = 0;

    }

    IEnumerator SwitchWeapons()
    {
        
        for (int i = 0; i < 3; i++)
        {  
            WaitForSeconds(5);

            if (i==1)
            {
                Weapon.arrow = 1;
                Weapon.sword = 0;
                Weapon.rocket = 0;
            }
            else if (i==2)
            {
                Weapon.arrow = 0;
                Weapon.sword = 1;
                Weapon.rocket = 0;
            }
            else
            {
                Weapon.arrow = 0;
                Weapon.sword = 0;
                Weapon.rocket = 1;
            }
        }
    }
    
}