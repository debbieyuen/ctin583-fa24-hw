using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    // Start is called before the first frame update\
    //blah blah

    Weapon myWeapon = new Weapon();
    void Start()
    {
        myWeapon.currentWeapon = myWeapon.sword;

        StartCoroutine(switchWeapon());
    }


    // Update is called once per frame
    void Update()
    {

    }

    // TODO: Problem 7: Why did I not include the words public or private here?
    // Answer: Because when you don't include is set to private by default. 
    // What does it mean when I only write void (Movement)? What does void mean?
    // Answer: void means you don't want things to return after the code finish running.



    void Movement()
    {
        // TODO: Problem 8: Please explain what the next 4 lines mean.
        // What is Input.GetAxis, transform.Translate, and transform.Rotate? 
        // Answer: The Input.GetAxis means get the input axis. The transform.Translate means to move the gameObject with certain direction's distance. The transform.Rotate means to get the rotate gameObject with certain rotation value.
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime; // Is to set the forwardMovement in Unity, by getting the Vertical axis input to times the speed and the time per frame.
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;// Is to set the turnMovement in Unity, by getting the Horizontal axis input to rotations times the speed and the time per frame.

        transform.Translate(Vector3.forward * forwardMovement); // this is the function actually move the gameObject.
        transform.Rotate(Vector3.up * turnMovement); // This is the function actually rotate the gameObject.
    }


    void Shoot()
    {
        // TODO: Problem 9: Looking at this code, is this code using Unity's Old or New 
        // Input System? Please describe what Instantiate is doing in this if statement.
        // Answer: This is Unity Old, because the Unity New will use InputAction. Instantiate is create a prefab instance.
        if (Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            myStuff.bullets--;
        }
    }

    private IEnumerator switchWeapon()//is for executing a sequence of events
    {
        while (true)
        {
            myWeapon.currentWeapon = myWeapon.arrow;

            yield return new WaitForSeconds(5f);

            myWeapon.currentWeapon = myWeapon.sword;

            yield return new WaitForSeconds(5f);

            myWeapon.currentWeapon = myWeapon.rocket;

            yield return new WaitForSeconds(5f);
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

public class Weapon
{
    public int arrow = 0;
    public int sword = 1;
    public int rocket = 2;

    public int currentWeapon;

}
