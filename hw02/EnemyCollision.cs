using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Problem 10
        Start(Couroutine(SwitchWeapons));


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // TODO: Problem 7: Why did I not include the words public or private here?
    // What does it mean when I only write void (Movement)? What does void mean?

//void doesn't return anything. We don't need it because we don't have anything in Update().
//It means that movement isn't returning anything and is just being called. 

    void Movement ()
    {
        // TODO: Problem 8: Please explain what the next 4 lines mean.
        // What is Input.GetAxis, transform.Translate, and transform.Rotate? 
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime; //This line is creating a variable that tells us how far the enemy should move forwards or backwards. 
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime; //This line is creating a variable that tells us how far the enemy should move side to side.


        transform.Translate(Vector3.forward * forwardMovement); //this code uses transform.Translate to actually move the enemy forward in the game.  
        transform.Rotate(Vector3.up * turnMovement); //this code uses transform.Rotate function to actually move the enemy side to side in the game.


        
    }
    
    void Shoot ()
    {
        // TODO: Problem 9: Looking at this code, is this code using Unity's Old or New 
        // Input System? Please describe what Instantiate is doing in this if statement.

        //This code is using Unity's old input system because we haven't imported the new input system using UnityEngine.InputSystem above
        //Instantiate is creating a new instance of a bullet. 



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


    Outside of our Weapon class, we would want to define an IEnumerator function. 
    Then in our class, write a for loop that loops between the arrow, sword, and rocket. 
    Use the WaitForSeconds function to tell it to switch weapons every 5 seconds. 

    Remember to call your Coroutine. 
    */ 

    public class Weapon
    {
        public int arrow;
        public int sword;
        public int rocket;

    }

    IEnumerator SwitchWeapons()
    {

    for (int i = 0; i < 3; i++)
        {
            if  (i == 0) 
            {
                Weapon.arrow = 1;
                Weapon.sword = 0;
                Weapon.rocket = 0;
                
            }
            else if (i == 1) {
                Weapon.arrow = 0;
                Weapon.sword = 1;
                Weapon.rocket = 0;

            }
            else if (i == 2) {
                Weapon.arrow = 0;
                Weapon.sword = 0;
                Weapon.rocket = 1;
            }
             else 
             {
                i = -1;
             }

            yield return new WaitForSeconds(5);
        
        }
        
    }
}