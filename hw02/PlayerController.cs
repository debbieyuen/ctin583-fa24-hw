// TODO: Problem 1: Write in the comments what each line of code is doing.
// What is "using" and what is System.Collections? Please provide comments on what the next three lines mean.

// using means to import a library. By writing "using System.Collections", we are importing the System.Collections library.
// Contains interfaces and classes that define various collections of objects, such as lists, queues, bit arrays, hashtables, and dictionaries.
using System.Collections; 
// Contains interfaces and classes that define generic collections, which allow users to create strongly typed collections that provide better type safety and performance than non-generic strongly typed collections.
using System.Collections.Generic;
// Contains the fundamental Unity classes.
using UnityEngine;

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
    */

    private string playerName = "Player";
    private float movementSpeed = 10f;
    private float gravityValue = 9.8f;
    private float jumpSpeed = 5f;
    // To grab our player controller in code, we would use GetComponent inside of the Start function 


    Console.WriteLine($"Player's Name: {playerName} Movement Speed: {movementSpeed} Gravity Value: {gravityValue} Jump Speed: {jumpSpeed}");
    
    // Start is called before the first frame update
    void Start()
    {
        // TODO: Problem 3: Describe when you would put code in the Start() function instead of the Update() function. 
        // What is the difference between Start() and Update()?

        // Start() is used to initialize the game state before the game starts. Update() is called once per frame and continuously updates the game state.
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Problem 4: What is an if statement? Write a couple of if statements to move the player with the WASD keys. 
        // We want to transform the player's position along the vertical and horizontal axis then multiply it by 
        // the corresponding variables we defined earlier. Lastly, we will need to multiply it all by Time.DeltaTime

        // An if statement is a conditional statement that runs a block of code if the condition is true.

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * movementSpeed * Time.deltaTime;
        }
    }

    // TODO: Problem 5: What do the lines here do? Please provide inline comments and describe what each line is doing
    // What do Header, SerializeField, and Tooltip mean?

    // Creates a labeled section inside the Unity editor to organize information 
    [Header("General Setup Settings")]
    // Allows a private variable to be displayed in the Unity editor
    [SerializeField] private InputAction movement;
    // Adds a tooltip to the following fields in the Unity Inspector. Provides additional information when hovered and exposes the field to the Unity Inspector
    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f;
    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f;
    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f;

    // TODO: Problem 6: What are Unity's OnEnable() and OnDisable functions?
    // What do movement.Enable() and movement.OnDisable do?

    // OnEnable is called when the object becomes enabled and active. OnDisable is called when the object becomes disabled or inactive. It serves as code that 
    // is executed when the object is enabled or disabled. movement.Enable() enables the movement input action, while movement.Disable() disables it.
    private void OnEnable()
    {
        movement.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
    }
}