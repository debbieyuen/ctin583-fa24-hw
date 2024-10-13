using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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
    private Vector2 barbieHeight = 1.75f;

    // Barbie is standing 2 feet or 0.6 meters away from the her party pinata
    private Vector2 barbieToPinataDistance = 0.6f;

    // The party pinata is hanging 8.2 feet or 2.5 meters high from the ground
    private Vector2 pinataHeight = 2.5f;

    // Barbie has 3 swings total each round
    private int remainingSwings = 3;

    void private Start() 
    {
        // magnitude the bat should swing at. Calculate the distance using Pythagorean theorem
        float heightDifference = pinataHeight - barbieHeight;
        float swingMagnitude = Mathf.Sqrt(Mathf.Pow(heightDifference, 2) + Mathf.Pow(barbieToPinataDistance, 2));
        Debug.Log("Swing magnitude needed: " + swingMagnitude);

        // Store Barbie's transform for easier reference
        barbieTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && remainingSwings >= 0)
        {
            // Problem 2: Check if Barbie is facing the pinata
            if (IsBarbieFacingPinata())
            {
                SwingAtPinata();
            }
            else
            {
                Debug.Log("Barbie is not facing the pinata! Cannot swing.");
            }
        }
        /*
        TODO: Problem 2: Barbie can only make a valid swing when she is looking directly at the pinata. She cannot swing at other objects, players, and items. 
        Check to make sure that Barbie is facing directly at the pinata. 
        * Hint: The target should be the pinata
        * Hint: Make the object points towards the object. Look at returns a quaterion and takes in a vector
        */      
        //Vector2 relativePosition = pinata.position - pinata.position;
        

        /*
        TODO: Problem 3: Barbie swings her bat and the bat hits the pinata. The pinata is now rotating along the x axis.
        If Barbie hits the bat again, we want the pinata to spin along the x axis and the y axis. How do we get the correct overall rotation of the pinata?
            * Hint: Think about quaternions. Why and how should we multiply a quaternion by a vector (say with Quaternion.Euler) and save it as a temporary variable?
            * Example: result = Quaternion.Euler(0,rotation, 0) * result;
            * Hint: Check if two Quaternions are equal to each other. If they are, print out "[Names of Quaterions] are Equal". Else, print out "Quaternions are different"
            * Hint: How can we rotate our vector? Can we use Quaternion.Lerp and Quaternion.Slerp?
        */
    }

    bool IsBarbieFacingPinata()
    {
        // Get direction from Barbie to the pinata
        Vector3 directionToPinata = pinata.position - barbieTransform.position;

        // Calculate the angle bewtween Barbie's forward direction and the direction to the pinata
        float angle = Vector3.Angle(barbieTransform.forward, directionToPinata);

        // If the angle is less than a small tolerance, Barbie is facing the pinata
        if (angle < 8.0f) // Allow a tolerance of 8 degrees
        {
            return true;
        }
        return false;

    }

    void SwingAtPinata()
    {
        // Decrement the swing count
        remainingSwings--;

        if (remainingSwings == 2)
        {
            Debug.Log("Remaining Swings 2!");
        }

        else if (remainingSwings == 1)
        {
            Debug.Log("Remaining Swings 1!");
        }

        else if (remainingSwings == 0)
        {
            Debug.Log("Remaining Swings 0!");
            Debug.Log("Barbie's turn is over. Next player's turn."); // If Barbie runs out of turns, it's the next player's turn
        }
    }

    // Problem 3
    void RotatePinata(Quaternion targetRotation)
    {
        // Rotate the pinata using Quaternion multiplication
        pinata.rotation = pinata.rotation * targetRotation;

        // Check if two rotations are equal for debugging
        if (pinata.rotation == targetRotation)
        {
            Debug.Log("Pinata has reached the target rotation.");
        }
        else
        {
            Debug.Log("Pinata rotation updated.");
        }
    }
}