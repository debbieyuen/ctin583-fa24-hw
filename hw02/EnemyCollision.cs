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
    void Movement ()
    {
        // TODO: Problem 8: Please explain what the next 4 lines mean.
        // What is Input.GetAxis, transform.Translate, and transform.Rotate?

        //Input.GetAxis is the GetAxis() method within the old Input class from Unity.
        //It takes in an axis as a parameter (normally defined in Unity's Project Settings).
        //The axes have three values: -1 , 0, and 1
        
        //Transform.Translate moves an object based on a vector
        //Transform.Rotate rotates an object based on a vector
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        
        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }
    
    
    void Shoot ()
    {
        // TODO: Problem 9: Looking at this code, is this code using Unity's Old or New 
        // Input System? Please describe what Instantiate is doing in this if statement.

        //This code uses Unity's old input system
        //Instantiate is creating a clone of the bullet prefab, setting its position and rotation to that of "firePosition".
        //Instantiate normally takes the type of GameObject, but is casted into the Rigidbody type to preform physics calculations

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

    public class Weapon : MonoBehaviour
    {
        public int arrow = 0;
        public int sword = 1;
        public int rocket = 2;
        public int[] weapons = new int[3];
        public bool isFrozen = false;

        private void Start()
        {
            weapons[0] = arrow;
            weapons[1] = sword;
            weapons[2] = rocket;
        }

        private void Update()
        {
            if (isFrozen == false)
            {
                for (int i = 0; i < weapons.Length; i++)
                {
                    Debug.Log("current weapon: " + weapons[i]);
                    StartCoroutine(SwapWeapons());
                    if (i == weapons.Length - 1)
                    {
                        i = 0;
                    }
                }
            }

        }

        public IEnumerator SwapWeapons()
        {
            yield return new WaitForSeconds(5f);
        }
    }
}

