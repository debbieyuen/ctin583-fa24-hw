using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can go here
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shoot();
    }
    
    // TODO: Problem 7: Why did I not include the words public or private here?
    // What does it mean when I only write void Movement()? What does void mean?
    
    // In C#, when a method does not specify "public" or "private," it defaults to private.
    // This means the function can only be accessed within this class.
    // The keyword "void" means that this function does not return any value.
    
    void Movement()
    {
        // TODO: Problem 8: Please explain what the next 4 lines mean.
        // What is Input.GetAxis, transform.Translate, and transform.Rotate?
        
        // "Input.GetAxis" retrieves the player's input for movement (from keyboard, joystick, etc.).
        // "Vertical" corresponds to W/S or Up/Down Arrow keys, "Horizontal" to A/D or Left/Right Arrows.
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime; 
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        
        // "transform.Translate" moves the object forward based on user input.
        transform.Translate(Vector3.forward * forwardMovement);
        
        // "transform.Rotate" rotates the object around the Y-axis based on input.
        transform.Rotate(Vector3.up * turnMovement);
    }
    
    void Shoot()
    {
        // TODO: Problem 9: Looking at this code, is this code using Unity's Old or New 
        // Input System? Please describe what Instantiate is doing in this if statement.

        // This code is using Unity's **Old Input System**, as it relies on "Input.GetButtonDown",
        // which is part of Unity's legacy input system (before the new Input System Package).
        // The new system would use "InputAction" objects and require additional setup.

        // "Instantiate" creates (spawns) a copy of the specified prefab in the scene.
        // In this case, it's spawning a bullet at "firePosition" with the same rotation.
        // The bullet is then given a force to move forward.
        if (Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            myStuff.bullets--;
        }
    }

    /* TODO: Problem 10: In our game, we want our enemy to alternate weapons every couple of frames.
    However, we also want our enemy to lose access to their weapons when they are frozen/disabled.
    First, let's define a public class named Weapon. In the class, define 3 int variables for arrow, sword, and rocket.
    
    Outside of our Weapon class, we would want to define an IEnumerator function. 
    Then in our class, write a for loop that loops between the arrow, sword, and rocket. 
    Use the WaitForSeconds function to tell it to switch weapons every 5 seconds. 

    Remember to call your Coroutine.
    */ 

    public class Weapon
    {
        public int arrow = 10;
        public int sword = 5;
        public int rocket = 2;
    }

    private Weapon enemyWeapon = new Weapon(); // Creating an instance of Weapon class.

    private bool isFrozen = false; // Variable to check if the enemy is frozen.

    void Start()
    {
        StartCoroutine(SwitchWeapons()); // Start the Coroutine when the game starts.
    }

    IEnumerator SwitchWeapons()
    {
        string[] weapons = { "Arrow", "Sword", "Rocket" };

        while (!isFrozen) // Only switch weapons when not frozen.
        {
            for (int i = 0; i < weapons.Length; i++)
            {
                Debug.Log("Enemy switched to: " + weapons[i]);

                // Wait for 5 seconds before switching to the next weapon.
                yield return new WaitForSeconds(5f);
            }
        }
    }

    // This function could be called when the enemy is frozen.
    public void FreezeEnemy()
    {
        isFrozen = true; // Stop the weapon switching when the enemy is frozen.
    }

    // This function could be called when the enemy is unfrozen.
    public void UnfreezeEnemy()
    {
        isFrozen = false; // Resume weapon switching when the enemy is active.
        StartCoroutine(SwitchWeapons()); // Restart Coroutine.
    }
}
