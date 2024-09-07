// TODO: Problem 1: Write in the comments what each line of code is doing.
// What is "using" and what is System.Collections? Please provide comments on what the next three lines mean. 

//"using" is a way to access namespaces. A namespace is a group of organized classes.
// System.Collections is the namespace being accessed. System.Collections provides a lot of basic classes and data structures like int32, and List<>

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
    public string playerName = "John";
    public float movementSpeed = 5f;

    public float gravityValue = 9.81f;

    public float jumpSpeed = gravityValue * 2;

    public PlayerController playerController;

    public Vector3 moveInput;

    public Rigidbody rb;
   
    
    // Start is called before the first frame update
    void Start()
    {
         Debug.Log("playerName" + playerName);
         Debug.Log("movementSpeed" + movementSpeed);
         Debug.Log("gravityValue" + gravityValue);
         Debug.Log("jumpSpeed" + jumpSpeed);
         playerController = GetComponent<PlayerController>();
         rb = GetComponent<Rigidbody>();
        // TODO: Problem 3: Describe when you would put code in the Start() function instead of the Update() function. 
        // What is the difference between Start() and Update()?

        //Any line of code you want to run the moment the game starts, you put in Start()
        //Any line of code you want to run consistently during the game, you put in Update()

        //Start() is called right before the first frame of unity, which is useful for things like initializing
        //variables or finding certain gameObjects

        //Update() is called every single frame, which is useful for things that happen consistently such as movement, timers, etc.
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Problem 4: What is an if statement? Write a couple of if statements to move the player with the WASD keys. 
        // We want to transform the player's position along the vertical and horizontal axis then multiply it by 
        // the corresponding variables we defined earlier. Lastly, we will need to multiply it all by Time.DeltaTime


        //Using Unity's built in Axis values in the Project Settings, you can code movement events without the need of "if" statements
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.z = Input.GetAxisRaw("Vertical");
        moveInput.Normalize();

        //Additionaly, it is better to use the built in velocity value of a rigidbody to calculate movement.
        //Simply moving the transform values of a gameObject can cause some weird issues, chief among them being potentially pushed through walls by enemies.
        //This is because physics aren't being calculated with methods like Transform.Translate().
        rb.velocity = moveInput * movementSpeed * Time.deltaTime;

    }

    // TODO: Problem 5: What do the lines here do? Please provide inline comments and describe what each line is doing
    // What do Header, SerializeField, and Tooltip mean? 
    [Header("General Setup Settings")] //puts a line in the inspector view showing a field as "General Setup Settings."
    [SerializeField] private InputAction movement; //Serialize Field allows private fields to be viewable in the inspector, when they normally are not visible.

    //When you hover over a variable that has a Tooltip, a small pop-up window is displayed showing relevant text to the variable.
    //This is useful for collaboration when developers need to know things about code written by another developer
    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f;
    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f;
    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f;

    // TODO: Problem 6: What are Unity's OnEnable() and OnDisable functions?
    // What do movement.Enable() and movement.OnDisable do?

    //OnEnable is called whenever a script component is set as active/when the gameobject the script is attatched to is set as active.
    //OnDisable is called whenever a script component is set as inactive /when the gameobject the script is attatched to is set as inactive.

    //As such, movement.Enable sets the InputAction movement to be active, and movement.Disable does the opposite.
    private void OnEnable()
    {
        movement.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
    }
}