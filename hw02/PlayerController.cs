 // TODO: Problem 1: Write in the comments what each line of code is doing.
 // What is "using" and what is System.Collections? Please provide comments on what the next three lines mean. 
using System.Collections;    // "Using" means that we're importing the System.Collections namespace to use in this script. System.Collections contains IEnumerator, which is necessary for couroutines in Unity.
using System.Collections.Generic;  // This is importing the System.Collections.Generic namespace. This namespace allows users to create strongly typed collections. Strongly typed languages predefine types of data- this helps with type safety and runtime performance, but limits flexibility.
using UnityEngine;   // This line is importing the UnityEngine namespace, which contains classes that are specific to Unity, including the base class for all scripts in unity- MonoBehaviour. 



public class PlayerController : MonoBehaviour
{
    /* 
    TODO: Problem 2: We are trying to move our player in an open world game. We would like the player to be able to move
    foward, backward, left, and right. In addition, the player should be able to jump and adapt to the world's gravity.
    First, we will need to define some variables in order to control our player with the WASD keys and the Space bar for it to jump. 
    Please define the following private variables and print them out to Unity's console: 
                1. Player or Character's Name
                2. Movement Speed as a float
                3. Gravity Value as a float
                4. Jump Speed as a float
    
    When the game starts, we would like to find our character. In our Unity Editor, we have a 3D model of our player and the player is 
    represented as a component in Unity. How do we grab our player controller in code and where should we write this line of code in this
    C# document (PlayerController.cs)?

   Answer: To grab the player controller in code, we would use GetComponent<PlayerController>() in the Start() function.

    */

//1. Declaring a variable for the player's name
    //Declaring a variabe for the player's name
        private string playerName = "Crazy Cool Player";

    //Printing the player's name to the console
         Debug.Log( "My player's name is" + playerName)


//2. Declaring a variable for the movement speed
    //Declaring a variable for the movement speed
        private float movementSpeed = 1f;

    //Printing the movement speed to the console    
        Debug.Log("My player's movement speed is" + movementSpeed);

//3. Declaring a variable for the gravity value
    //Declaring a variable for the gravity value
        private float gravityValue = 1f;

    //Printing the gravity value to the console
        Debug.Log("The gravity value is" + gravityValue);

//4. Declaring a variable for the jump speed
    //Declaring a variable for the jump speed
        private float jumpSpeep = 1f;

    //Printing the jump speed to the console
        Debug.Log("The jump speed is" + jumpSpeed);

    




    
    // Start is called before the first frame update
    void Start()
    {
        // TODO: Problem 3: Describe when you would put code in the Start() function instead of the Update() function. 
        // What is the difference between Start() and Update()?

        //Answer:  Start() is called at the beginning of the game, before the first frame update. You would put code in the Start() function when you want to initialize anything that needs to be set up at the beginning of the game- like setting the player's starting position or initializing variables.
        // Update() is called once per frame as the game runs. You would put code in the Update() function that needs to be updated every frame like player input or collision detection. 
        //The difference between Start() and Update() is that Start() is called once at the beginning of the game, while Update() is called once per frame as the game runs.



    // Update is called once per frame
    void Update()
    {
        // TODO: Problem 4: What is an if statement? Write a couple of if statements to move the player with the WASD keys. 
        // We want to transform the player's position along the vertical and horizontal axis then multiply it by 
        // the corresponding variables we defined earlier. Lastly, we will need to multiply it all by Time.DeltaTime


        //Answer: An if statement is a conditional statement that executes a block of code if a specified condition is true. 
        //Time.deltaTime is needed here, because it is the time in seconds it took to complete the last frame. So, multiplying the movement by Time.deltaTime ensures that the movement is frame rate independent, which means that regardless of the FPS, the player's movement will be executed at the same speed.
        //This way, player movement will be uniform across all devices for all players. Otherwise, players with higher FPS would move faster than players with lower FPS.

        
        
        //If the player presses the "W" key, move the player forward
        if (Input.GetKey(KeyCode.W))
        {
            //move the ridigbody forward
            transform.position += Vector3.forward * movementSpeed * Time.deltaTime;
        }

        //If the player presses the "S" key, move the player back
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * movementSpeed * Time.deltaTime;
        }

        //If the player presses the "A" key, move the player left
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * movementSpeed * Time.deltaTime;
        }

        //If the player presses the "D" key, move the player right
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * movementSpeed * Time.deltaTime;
        }



    }

    // TODO: Problem 5: What do the lines here do? Please provide inline comments and describe what each line is doing
    // What do Header, SerializeField, and Tooltip mean? 

    //Header is used to create a header in the inspector, SerializeField is used to make the variable visible in the inspector, and Tooltip shows a message when you hover over the variable in the inspector. 
    //You always need to includ SerializeField when you want to make a variable visible in the inspector.

    [Header("General Setup Settings")]  //This line of code will create a header titled "General Setup Settings" in the inspector.
    [SerializeField] private InputAction movement; //Unity doesn't serialize private fields by default, so SerializeField is used to make the InputAction variable movement visible in the inspector.
    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f; //This line of code will show the message "How fast player moves up and down based upon player input" when you hover over the controlSpeed variable in the inspector.
    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f; //The Tooltip will show the message "How far player moves horizontally" when you hover over the xRange variable in the inspector.
    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f; //The Tooltip will show the message "How far player moves vertically" when you hover over the yRange variable in the inspector.

   



    // TODO: Problem 6: What are Unity's OnEnable() and OnDisable functions?
    // What do movement.Enable() and movement.OnDisable do?

    //Answer: Everything in OnEnable() is the code that gets run when the object is enabled. 
    //Everything in OnDisable() is the code that gets run  when the object is deactivated.
    //movement.Enable() enables the InputAction, so we can move the object, while movement.Disable() does the opposite. 

    private void OnEnable()
    {
        movement.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
    }
}