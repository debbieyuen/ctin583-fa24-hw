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
    //ANSWER: not including public or private will have the class be private as default, void means that we are not returning a value.

    void Movement ()
    {
        // TODO: Problem 8: Please explain what the next 4 lines mean.
        // What is Input.GetAxis, transform.Translate, and transform.Rotate? 
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;//ANSWER making a float that is equal to the vertical input times the speed times Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;//ANSWER making a float that is equal to the horizontal input times the speed times Time.deltaTime;
        
        transform.Translate(Vector3.forward * forwardMovement); //ANSWER get the transform of this object and then translate it forward multiplied by forwardMovement
        transform.Rotate(Vector3.up * turnMovement); //ANSWER get the transform of this object and then rotate it up multiplied by turnMovement
    }
    
    
    void Shoot ()
    {
        // TODO: Problem 9: Looking at this code, is this code using Unity's Old or New 
        // Input System? Please describe what Instantiate is doing in this if statement.
        //ANSWER: This is using Unity's old input system. Instantiate is creating a new bullet at using a bullet prefab and placing it on the firePosition.position and giving it rotation.
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
    */ 
    public class Weapon(){
        int arrow;
        int sword;
        int rocket;
    }
}