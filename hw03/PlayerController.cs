// TODO: Problem 1: Write in the comments what each line of code is doing.
// What is "using" and what is System.Collections? Please provide comments on what the next three lines mean. 
// "using" denotes that we're importing the functionalities included in this "collection'
// System.Collections is part of Unity's phsyics system and lets us detect collisions
using System.Collections;
using System.Collections.Generic;
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

    private var playerName = "Player";
    private float speed = 2.0;
    private float gravity = 9.86;
    private float jumpSpeed = 3.0;

    Console.Write(playerName);
    Console.Write(speed);
    Console.Write(gravity);
    Console.Write(jumpSpeed);

    // we can grab the playercontroller using the code <PlayerController player = FindObjectOfType<PlayerController>();> put in the start function

    
    // Start is called before the first frame update
    void Start()
    {
        // TODO: Problem 3: Describe when you would put code in the Start() function instead of the Update() function. 
        // What is the difference between Start() and Update()?

        // I would put code in the start function that I want to declare or initiate once in the beginning of my game.
        // Code that I want to run over and over or to change things over time I would put in the update function
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Problem 4: What is an if statement? Write a couple of if statements to move the player with the WASD keys. 
        // We want to transform the player's position along the vertical and horizontal axis then multiply it by 
        // the corresponding variables we defined earlier. Lastly, we will need to multiply it all by Time.DeltaTime

        Vector3 moveDirection = Vector3.zero; // Holds the direction of movement.

        if (Input.GetKey(KeyCode.W)) // Move forward
        {
            moveDirection += Vector3.forward;
        }

        if (Input.GetKey(KeyCode.S)) // Move backward
        {
            moveDirection += Vector3.back;
        }

        if (Input.GetKey(KeyCode.A)) // Move left
        {
            moveDirection += Vector3.left;
        }

        if (Input.GetKey(KeyCode.D)) // Move right
        {
            moveDirection += Vector3.right;
        }

        // Apply movement
        transform.position += moveDirection * speed * Time.deltaTime;

    }

    // TODO: Problem 5: What do the lines here do? Please provide inline comments and describe what each line is doing
    // What do Header, SerializeField, and Tooltip mean? \

    // This adds a header in the Unity Inspector for organization.
    [Header("General Setup Settings")]

    // SerializeField allows private variables to be visible and editable in the Inspector without making them public
    // Tooltip provides a small pop-up description when hovering over a variable in the Unity Inspector

    // Exposes the 'movement' variable in the Unity Inspector but keeps it private.
    [SerializeField] private InputAction movement;
    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f;
    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f;
    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f;

    // TODO: Problem 6: What are Unity's OnEnable() and OnDisable functions?
    // What do movement.Enable() and movement.OnDisable do?
    
    // OnEnable() is called when the object/script is activated. It is useful for subscribing to events or enabling input actions.
    private void OnEnable()
    {
        movement.Enable();
    }

    // OnDisable() is called when the object/script is deactivated. It is useful for unsubscribing from events or disabling input actions to avoid errors.
    private void OnDisable()
    {
        movement.Disable();
    }
}