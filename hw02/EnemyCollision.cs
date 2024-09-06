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
    //public can be accessed from any class within a namespace, while private can only be accessed within the scope where it is defined
    // What does it mean when I only write void (Movement)? What does void mean?
    //Void means that the method doesn't return anything. Void means that the function won't return a value to anything outside from within its own function. 
    void Movement ()
    {
        // TODO: Problem 8: Please explain what the next 4 lines mean.
        // What is Input.GetAxis, transform.Translate, and transform.Rotate? 
        /* Input.GetAxis is to return the value of the virtual axis identified by axisName. The value will be in the range -1...1 for keyboard and joystick input devices.
           transform.Translate is to move the transform in the direction and distance of translation.
           transform.Rotate is to rotate GameObjects in a variety of ways. The rotation is often provided as an Euler angle and not a Quaternion.
        */

        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        //With key presses, you are going to get a -1, 0, or a 1. So the vertical axis might be set for the W and S keys. If W is pressed, you get a 1. If it��s not pressed, you get a 0. So when it is pressed, the player will move at the specified speed since you multiplied the speed by 1. And when it��s not pressed, you��ll multiply it by 0 and not move in that direction. 
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        //With key presses, you are going to get a -1, 0, or a 1. So the vertical axis might be set for the D and W keys. If W is pressed, you get a 1. If it��s not pressed, you get a 0. So when it is pressed, the player will move at the specified speed since you multiplied the speed by 1. And when it��s not pressed, you��ll multiply it by 0 and not move in that direction.
        transform.Translate(Vector3.forward * forwardMovement);
        //Move a GameObject in XZ space(forward, back, left, or right) in the distance of "forwardMovement"
        transform.Rotate(Vector3.up * turnMovement);
        ///Rotate a GameObject in the direction of "turnMovement"
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
            //Instantiate makes a copy of an object in a similar way to the Duplicate command in the editor. If you are cloning a GameObject you can specify its position and rotation
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
    
    public class Weapon: MonoBehaviour
    {
        private int arrow;
        private int sword;
        private int rocket;
    }
    IEnumerator WeaponSwitch()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            // Switch weapons here
        }
    }

    void Start()
    {
        StartCoroutine(WeaponSwitch());
    }

}