using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SwitchWeapon());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // TODO: Problem 7: Why did I not include the words public or private here?
    // What does it mean when I only write void (Movement)? What does void mean?
    void Movement () // when no access modifier (public/private) is specified, it defaults to private; void means that the method does not return a value, just perform some sort of action(s)
    {
        // TODO: Problem 8: Please explain what the next 4 lines mean.
        // What is Input.GetAxis, transform.Translate, and transform.Rotate? 
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;  // gets input values between -1 and 1 from vertical axis (w/s or up/down keys)
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime; // gets input values between -1 and 1 from horizontal axis (a/d or left/right keys)
        // Input.GetAxis reads a player input from a specified axis (Vertical, Horizontal, etc) and returns a float value between -1 and 1
        
        transform.Translate(Vector3.forward * forwardMovement); // moves object forward/backward based on input
        transform.Rotate(Vector3.up * turnMovement); // rotates object left/right based on input
        // transform.Translate moves an object in a given direction by a specified amount
        // transform.Rotate rotates an object around specified axes
    }
    
    
    void Shoot ()
    {
        // TODO: Problem 9: Looking at this code, is this code using Unity's Old or New 
        // Input System? Please describe what Instantiate is doing in this if statement.
        if(Input.GetButtonDown("Fire1") && myStuff.bullets > 0) // this is Unity's Old Input System since it uses Input.GetButtonDown(); new system uses InputAction and requires a different setup in PlayerInput
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody; // here, Instantiate() create a new bullet at firePosition with the specified rotation, then casts it as a Rigidbody
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

    public class Weapon { // arbitrary values of each weapon
        public int arrow = 14;
        public int sword = 7;
        public int rocket = 3;
    }

    private int currentWeapon; // keep track of enemy's current weapon
    private IEnumerator SwitchWeapon () {
        Weapon weapons = new Weapon();

        while(enabled) { // only when enemy is active

        // change out weapons every 5 seconds
        currentWeapon = weapons.arrow;
        yield return new WaitForSeconds(5);

        currentWeapon = weapons.sword;
        yield return new WaitForSeconds(5);

        currentWeapon = weapons.rocket;
        yield return new WaitForSeconds(5);
        }
    }
}