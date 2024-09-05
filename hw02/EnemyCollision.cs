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

    // Answer 7
    // Because the default access modifier for a class member is private.
    // So, if you don't write anything, it is private.
    // void means that the function does not return any value.
    // This means function Movement does not return anything.

    void Movement ()
    {
        // TODO: Problem 8: Please explain what the next 4 lines mean.
        // What is Input.GetAxis, transform.Translate, and transform.Rotate? 
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        // Answer 8.1
        // Input.GetAxis is a function that returns the value of the virtual axis identified by the axisName.
        // So it returns a float value between -1 and 1, and give value to forwarDmovement.
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        // Answer 8.2
        // It is the same as the forwardMovement, but it is for the horizontal axis.
        // It gives value to turnMovement.
        // We can use there values to control the movement and rotation of the object.

        transform.Translate(Vector3.forward * forwardMovement);
        // Answer 8.3
        // It moves the transfrom in the direction and distance of translation.
        transform.Rotate(Vector3.up * turnMovement);
        // Answer 8.4
        // It rotates the transform about the y-axis by angle degrees.
    }


    void Shoot ()
    {
        // TODO: Problem 9: Looking at this code, is this code using Unity's Old or New 
        // Input System? Please describe what Instantiate is doing in this if statement.

        // Answer 9.1
        // I think this code is using Unity's old input system.
        // Because it uses the GetButtonDown function.
        // Instantiate is a function that creates a clone of the object original and returns the clone.
        // In this code, Instantiate can be viewed as a cloning behaviour.
        // The function here defines which object to clone, at what position, and the angle of its rotation.
        // After that, we add force to it, which implements the logic for shooting the bullet.
        // In addition to this,
        // we can add a tag to the bullet so that it can be used to detect when the game character collides later for damage determination.
        if (Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
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
}

public class Weapons
{
    public int arrow;
    public int sword;
    public int rocket;

    // Constructor to initialize weapon counts if needed
    public Weapons(int arrowCount, int swordCount, int rocketCount)
    {
        arrow = arrowCount;
        sword = swordCount;
        rocket = rocketCount;
    }
}

public class Enemy : MonoBehaviour
{
    public Weapon weapon;
    private bool isFrozen = false;

    void Start()
    {
        weapon = new Weapon();
        StartCoroutine(SwitchWeapons());
        // Important note: StartCoroutine is a method in Unity that starts a coroutine.
        // Coroutines are special methods that can pause execution and yield control back to Unity,
        // and then continue from where they left off on the following frame or after a specified amount of time. 
    }

    IEnumerator SwitchWeapons()
    {
        while (true)
        {
            if (!isFrozen)
            {
                for (int i = 0; i < 3; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Debug.Log("Switching to Arrow");
                            // Logic to switch to arrow
                            break;
                        case 1:
                            Debug.Log("Switching to Sword");
                            // Logic to switch to sword
                            break;
                        case 2:
                            Debug.Log("Switching to Rocket");
                            // Logic to switch to rocket
                            break;
                    }
                    yield return new WaitForSeconds(5);
                }
            }
            else
            {
                yield return null; // Wait until the enemy is not frozen
            }
        }
    }

    public void FreezeEnemy()
    {
        isFrozen = true;
    }

    public void UnfreezeEnemy()
    {
        isFrozen = false;
    }
    // This function can be called to freeze or unfreeze the enemy base on the game logic.
}