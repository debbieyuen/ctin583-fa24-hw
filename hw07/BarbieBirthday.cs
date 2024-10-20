using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;


/* 
Homework Problems

It is Barbie's Birthday and she is hosting a birthday party!
We are in a 2D World celebrating Barbie's Birthday and we are getting ready to break the pinata. 
First, we would like to position Barbie and the pinata correctly. 

Barbie is 5'9'' or 1.75 meters tall. 
She is standing 2 feet or 0.6 meters away from the her party pinata.
The party pinata is hanging 8.2 feet or 2.5 meters high from the ground.
Assume that the angles between the distance of the pinata to the ground and Barbie's distance to the pinata create a 90 degree angle. 
TODO: Problem 1: Barbie is holding a bat to swing at the pinata. What should be the magnitude the bat should swing at? Make sure the check for edge cases including:
     * Barbie has only three chances to swing at the pinata before it is the next player's turn
     * If Barbie runs out of turns, a message should display that Barbie's turn is over and it is the next player's turn
*/
public class BarbieBirthday : MonoBehaviour
{
    // Transform for Barbie's party pinata
    [SerializeField] Transform pinata; 

    // The pinata's rotation along the X axis for the first successful hit (Quaternion)
    [SerializeField] Quaternion rotationX;

    // The pinata's rotation along the Y axis for the second successful hit (Quaternion)
    [SerializeField] Quaternion rotationY;

    // Particle System for the third successful hit
    [SerializeField] ParticleSystem candyExplosion;

    // Barbie's height is Barbie is 5'9'' or 1.75 meters tall
    private Vector2 barbieHeight = new Vector2(0, 1.75f);

    // Barbie is standing 2 feet or 0.6 meters away from the her party pinata
    private Vector2 barbieToPinataDistance = new Vector2(0.6f, 0);

    // The party pinata is hanging 8.2 feet or 2.5 meters high from the ground
    private Vector2 pinataHeight = new Vector2(0, 2.5f);
    private int attempts = 3;

    private float swingMagnitude = 0f;

    private Quaternion currentRotation = Quaternion.identity;

    // Update is called once per frame
    void Update()
    {
        /*
        TODO: Problem 2: Barbie can only make a valid swing when she is looking directly at the pinata. She cannot swing at other objects, players, and items. 
        Check to make sure that Barbie is facing directly at the pinata. 
        * Hint: The target should be the pinata
        * Hint: Make the object points towards the object. Look at returns a quaterion and takes in a vector
        */


        if (transform.forward == pinata.position) 
        {
            if (Input.GetMouseButtonDown(0)) 
            {
                Swing();
                RotatePinata(currentRotation, currentRotation, attempts);
            }
        }
        else 
        {
            transform.LookAt(pinata.position);
            return;
        }

        Vector2 relativePosition = pinata.position - pinata.position;

        /*
        TODO: Problem 3: Barbie swings her bat and the bat hits the pinata. The pinata is now rotating along the x axis.
        If Barbie hits the bat again, we want the pinata to spin along the x axis and the y axis. How do we get the correct overall rotation of the pinata?
            * Hint: Think about quaternions. Why and how should we multiply a quaternion by a vector (say with Quaternion.Euler) and save it as a temporary variable?
            * Example: result = Quaternion.Euler(0,rotation, 0) * result;
            * Hint: Check if two Quaternions are equal to each other. If they are, print out "[Names of Quaterions] are Equal". Else, print out "Quaternions are different"
            * Hint: How can we rotate our vector? Can we use Quaternion.Lerp and Quaternion.Slerp?
        */
    }

    private void Swing() 
    {
        if (attempts <= 0) 
        {
            Debug.Log("Out of attempts! Next player's turn");
            return;
        }

        //form a right triangle to calculate swing distance
        Vector2 heightDifference = new Vector2 (0, pinataHeight.y - barbieHeight.y);

        //the hypotenuse represents the swing path
        swingMagnitude = Mathf.Sqrt(Mathf.Pow(heightDifference.y, 2) + Mathf.Pow(barbieToPinataDistance.x, 2));
        attempts--;

    }

    //Problem 3 solution
    private void RotatePinata(Quaternion xRotation, Quaternion yRotation, int attemptNum) 
    {
        Quaternion defaultRotation = Quaternion.identity;
        xRotation = Quaternion.identity;
        yRotation = Quaternion.identity;

        switch (attemptNum) {
            case 2 : {
                xRotation = Quaternion.Euler(45, 0, 0);
                pinata.rotation = xRotation;
                Quaternion.Slerp(defaultRotation, xRotation, Time.deltaTime);
                break;
            }
            case 1 : {
                yRotation = Quaternion.Euler(0, 45, 0);
                pinata.rotation = rotationX * rotationY;
                Quaternion.Slerp(defaultRotation, pinata.rotation, Time.deltaTime);

                if (rotationX.Equals(rotationY)) {
                    Debug.Log("Rotations are equal");
                }
                else 
                {
                    Debug.Log("Rotations are different");
                }
                break;
            }
            case 0 : {
                candyExplosion.Play();
                break;
            }
            default : {
                Debug.Log("Pinata is broken!");
                break;
            }
        }
    }
}