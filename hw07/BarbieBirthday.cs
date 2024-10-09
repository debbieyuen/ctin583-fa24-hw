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
    private Vector2 barbieHeight = new Vector2(0,1.75f);

    // Barbie is standing 2 feet or 0.6 meters away from the her party pinata
    private Vector2 barbieToPinataDistance = new Vector2(0.6f, 0);

    // The party pinata is hanging 8.2 feet or 2.5 meters high from the ground
    private Vector2 pinataHeight  new Vector2(0,2.5f);

   //Solve problem 1
    private int swingsRemaining = 3;
    private float requiredSwingMagnitude;
    private int successfulHits = 0;

    private void Start()
    {
        CalculateRequiredSwingMagnitude();
    }
    private void CalculateRequiredSwingMagnitude()
    {
        float heightDifference = pinataHeight.y - barbieHeight.y;
        requiredSwingMagnitude = Mathf.Sqrt(Mathf.Pow(heightDifference,2) +  Mathf.Pow(barbieToPinataDistance.x,2));
    }
    public void Swing(float swingMagnitude)
    {
        if(swingsRemaining<=0)
        {
            Debug.Log("Barbie has run out three chances to swing at the pinata");
            return;
        }
           
        swingsRemaining--;
    }

     //Solve problem 2
        private bool IsFacingPinate()
        {
        Vector2 barbieToPinata = new Vector2(pinata.transform.position.x-transform.position.x, pinata.transform.position.y-transform.position.y);
            float angle = Vector2.Angle(transform.right, barbieToPinata);
            return angle < 5f;
      
        }
        private void HandSuccessfulHit()
        {
            successfulHits++;

            switch (successfulHits)
            {
                case 1:
                    pinata.rotation  =  rotationX;
                    break;
                case 2:
                    Quaternion combinedRotation = rotationX * rotationY;
                    pinata.rotation = combinedRotation;
                    CompareQuaternions(rotationX, rotationY);
                    break;
                case 3:
                    candyExplosion.Play();
                
                    break;

            }

        }
       //Solve problem 2
        private bool IsFacingPinate()
        {
        Vector2 barbieToPinata = new Vector2(pinata.transform.position.x-transform.position.x, pinata.transform.position.y-transform.position.y);
            float angle = Vector2.Angle(transform.right, barbieToPinata);
            return angle < 5f;
      
        }
        private void HandSuccessfulHit()
        {
            successfulHits++;

            switch (successfulHits)
            {
                case 1:
                    pinata.rotation  =  rotationX;
                    break;
                case 2:
                    Quaternion combinedRotation = rotationX * rotationY;
                    pinata.rotation = combinedRotation;
                    CompareQuaternions(rotationX, rotationY);
                    break;
                case 3:
                    candyExplosion.Play();
                
                    break;

            }

        }
         private void CompareQuaternions(Quaternion q1, Quaternion q2)
            {
                if (Quaternion.Angle(q1, q2) < 0.1f)
                {
                    Debug.Log("rotationX and rotationY are Equal");
                }
                else
                {
                    Debug.Log("Quaternions are different");
                }
             }



    // Update is called once per frame
    void Update()
    {
        /*
        TODO: Problem 2: Barbie can only make a valid swing when she is looking directly at the pinata. She cannot swing at other objects, players, and items. 
        Check to make sure that Barbie is facing directly at the pinata. 
        * Hint: The target should be the pinata
        * Hint: Make the object points towards the object. Look at returns a quaterion and takes in a vector
        */      
        Vector2 relativePosition = pinata.position - pinata.position;

        if (IsFacingPinate())
        {
            Debug.Log("Barbie is facing the pinata");
        }
        /*
        TODO: Problem 3: Barbie swings her bat and the bat hits the pinata. The pinata is now rotating along the x axis.
        If Barbie hits the bat again, we want the pinata to spin along the x axis and the y axis. How do we get the correct overall rotation of the pinata?
            * Hint: Think about quaternions. Why and how should we multiply a quaternion by a vector (say with Quaternion.Euler) and save it as a temporary variable?
            * Example: result = Quaternion.Euler(0,rotation, 0) * result;
            * Hint: Check if two Quaternions are equal to each other. If they are, print out "[Names of Quaterions] are Equal". Else, print out "Quaternions are different"
            * Hint: How can we rotate our vector? Can we use Quaternion.Lerp and Quaternion.Slerp?
        */
        //Solve problem 3

        if (successfulHits > 0 && successfulHits < 3)
        {
            Quaternion targetRotation = (successfulHits == 1) ? rotationX : (rotationX * rotationY);
            pinata.rotation = Quaternion.Slerp(pinata.rotation, targetRotation, Time.deltaTime);
        }
    }
}
