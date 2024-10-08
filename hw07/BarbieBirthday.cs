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

TODO: Problem 2: Barbie can only make a valid swing when she is looking directly at the pinata. She cannot swing at other objects, players, and items. 
        Check to make sure that Barbie is facing directly at the pinata. 
        * Hint: The target should be the pinata
        * Hint: Make the object points towards the object. Look at returns a quaterion and takes in a vector

TODO: Problem 3: Barbie swings her bat and the bat hits the pinata. The pinata is now rotating along the x axis.
        If Barbie hits the bat again, we want the pinata to spin along the x axis and the y axis. How do we get the correct overall rotation of the pinata?
            * Hint: Think about quaternions. Why and how should we multiply a quaternion by a vector (say with Quaternion.Euler) and save it as a temporary variable?
            * Example: result = Quaternion.Euler(0,rotation, 0) * result;
            * Hint: Check if two Quaternions are equal to each other. If they are, print out "[Names of Quaterions] are Equal". Else, print out "Quaternions are different"
            * Hint: How can we rotate our vector? Can we use Quaternion.Lerp and Quaternion.Slerp?
*/
public class BarbieBirthday : MonoBehaviour
{
    // Serialized Fields
    [SerializeField] Transform pinata;
    [SerializeField] Quaternion rotationX;
    [SerializeField] Quaternion rotationY;
    [SerializeField] ParticleSystem candyExplosion;

    // Barbie's Height and distances
    private float barbieHeight = 1.75f;
    private float barbieToPinataDistance = 0.6f;
    private float pinataHeight = 2.5f;

    private int maxSwings = 3;
    private int currentSwings = 0;

    void Update()
    {
        // Make Barbie face the pinata
        transform.LookAt(pinata);

        // Check if it is Barbie's turn
        if (currentSwings < maxSwings)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SwingBat();
                RotatePinata();
                currentSwings++;
            }
        }
        else
        {
            Debug.Log("Barbie's turn is over. It is the next player's turn.");
        }

    }

    // Swing the bat and calculate the magnitude of the bat swing
    float SwingBat()
    {
        float DistanceToPinata = Vector3.Distance(transform.position, pinata.position);
        return DistanceToPinata;
    }

    void RotatePinata()
    {
        if (currentSwings == 1)
        {
            pinata.rotation = Quaternion.Euler(30f, 0f, 0f) * pinata.rotation;
        }
        else if (currentSwings == 2)
        {
            pinata.rotation = Quaternion.Euler(30f, 30f, 0f) * pinata.rotation;
        }
    }
}