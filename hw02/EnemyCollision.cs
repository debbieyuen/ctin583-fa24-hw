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
    
    //public means you can access it globally,while private you can not. if no modifier is provided, it defalts to private
    //void is a return type, it means the function doesn't return a value.
    void Movement ()
    {
        // TODO: Problem 8: Please explain what the next 4 lines mean.
        // What is Input.GetAxis, transform.Translate, and transform.Rotate? 
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        //detects forward and backward movement
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        //detects turning movement
        transform.Translate(Vector3.forward * forwardMovement);
        //move the player forward/backward depending on input and speed
        transform.Rotate(Vector3.up * turnMovement);
        //rotates the player along the y axis, which is to rotate left or right based on input and speed.
        
       
    }
    
    
    void Shoot ()
    {
        // TODO: Problem 9: Looking at this code, is this code using Unity's Old or New 
        // Input System? Please describe what Instantiate is doing in this if statement.
        if(Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            myStuff.bullets--;
        }
    }
    // this is the old system. The instantiate function is generating a bullet at the fireposition and shooting it forwards at a given speed

    /* TODO: Problem 10: In our game, we want our enemy to alternate weapons every couple of frames.
    However, also would like our enemy to lose access to their weapons when they are frozen/disabled.
    First, let's define a public class named Weapon. In the class, define 3 int variables for arrow, sword, and rocket.
    

    Outside of our Weapon class, we would want to define an IEnumerator function. 
    Then in our class, write a for loop that loops between the arrow, sword, and rocket. 
    Use the WaitForSeconds function to tell it to switch weapons every 5 seconds. 
    
    Remember to call your Coroutine.
    */

    public bool frozen = false;
    public class Weapon
    {
        private int arrow = 1;
        private int sword = 2;
        private int rocket = 3 ;
        
        
        for (int i = 0; i < 3; i++)
        {
            //you do something here to actually switch the weapons but I don't know how
            StartCoroutine(SwitchWeapons());
        }
    }

    IEnumerator SwitchWeapons()
    {
        if(!frozen) 
        {
            yield return new WaitForSeconds(5f);
        }
}
