// TODO: Problem 1: Write in the comments what each line of code is doing.
// What is "using" and what is System.Collections? Please provide comments on what the next three lines mean. 


//Answer 1
// the 'using' directive is used to include namespaces in our file.
// A namespace is a collection of classes, interfaces, enums, and other types that are used to organize code and prevent naming conflicts.
using System.Collections;
// This line includes the System.Collections namespace,
// defining an array of interfaces and classes that inspire various collections of objects, such as lists, queues, arrays......
using System.Collections.Generic;
// This namespace contains classes for generic collections, such as List<T>, Dictionary<TKey,TValue>, and others.
// These T-values are more flexible in that they can change type when called.(Or perhaps more flexible?)
using UnityEngine;
// This line includes the UnityEngine namespace, which is specific to Unity and contains classes and functions for game development.
// It includes a lot of things from game object control, physics, rendering, and other core functionalities of Unity.

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
    */

    // Answer 2.1
    // These are the variables that we will be using to control our player.
    private string playerName = "Player";
    private float movementSpeed = 10.0f;
    private float gravityValue = 9.8f;
    private float jumpSpeed = 10.0f;
    // If we want change the name of player through the console, we can use the following code:
    playername=Console.ReadLine();
    Console.WriteLine("The player's name is: " + playerName);
    // If we want to print the values of the variables to the Unity, we can use the following code:
    Debug.Log("The player's name is: " + playerName);
    Debug.Log("The player's movement speed is: " + movementSpeed);
    debug.Log("The player's gravity value is: " + gravityValue);
    Debug.Log("The player's jump speed is: " + jumpSpeed);
    // These lines of code will print the values of the variables to the Unity console
    // while we need to put them in the Start() or suitable function.    


    /*
    When the game starts, we would like to find our character. In our Unity Editor, we have a 3D model of our player and the player is 
    represented as a component in Unity. How do we grab our player controller in code and where should we write this line of code in this
    C# document (PlayerController.cs)?
    */

    // Answer 2.2
    private GameObject player;
    // We can grab our player controller in code by using the following line of code:
    GameObject player = GameObject.Find("Player");
    // We should write this line of code in the Start() function in the PlayerController.cs file.




    // Start is called before the first frame update
    void Start()
    {
        // TODO: Problem 3: Describe when you would put code in the Start() function instead of the Update() function. 
        // What is the difference between Start() and Update()?
        
        // Answer 3
        // I use Start() if I want something to be executed only at the beginning and only once.
        // Also, I use Update() when I want something to be executed every frame.
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Problem 4: What is an if statement? Write a couple of if statements to move the player with the WASD keys. 
        // We want to transform the player's position along the vertical and horizontal axis then multiply it by 
        // the corresponding variables we defined earlier. Lastly, we will need to multiply it all by Time.DeltaTime

        // Answer 4
        // First, I have already defined the variables for the player's movement speed before, so I will use it in the if statement.
        Vector3 moveDirection = Vector3.zero;// (0,0,0)
        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += transform.forward; // Move forward
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection -= transform.forward; // Move backward
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection -= transform.right; // Move left
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += transform.right; // Move right
        }
        transform.position += moveDirection * moveSpeed * Time.deltaTime;// update the position of the player
        // However, it is not the only way to move characters in Unity.
        // We can also use the following code to move the player:
        // float horizontal = Input.GetAxis("Horizontal");
        // float vertical = Input.GetAxis("Vertical");
        // Vector3 move = new Vector3(horizontal, 0, vertical);
        // transform.Translate(move * movementSpeed * Time.deltaTime);
        // And using the Input System, we can also move the player!!!
        // Different implementations can cause subtle differences in movement, and I'm interested in looking into them further.
    }

    // TODO: Problem 5: What do the lines here do? Please provide inline comments and describe what each line is doing
    // What do Header, SerializeField, and Tooltip mean? 

    [Header("General Setup Settings")]
    // Answer 5.1
    // This is a attribute that adds a header label in the Unity Inspector above the following serialized fields.
    // It can clearly separate different sections of the Inspector.
    // In this example, the header is "General Setup Settings", and it would show up in the Inspector.

    [SerializeField] private InputAction movement;
    // Answer 5.2
    // This is a attribute that makes a variable appear in the Unity Inspector.
    // It allows me to edit the variable in the Inspector without making it public.
    // In this example, the variable is "movement", and it would show up in the Inspector.

    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f;
    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f;
    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f;
    // Answer 5.3
    // This is a attribute that adds a tooltip to the variable in the Unity Inspector.
    // It is really usable as it can provide a description of the variable in the Inspector.
    // So when I miss the meaning of the variable, I can check the tooltip by hovering over the variable in the Inspector.

    // TODO: Problem 6: What are Unity's OnEnable() and OnDisable functions?
    // What do movement.Enable() and movement.OnDisable do?
    private void OnEnable()
    {
        movement.Enable();

        // Answer 6.1
        // OnEnable() is called when the object becomes enabled and active.
        // In this example, it is called when the script is enabled.
        // And players can move the character when the script is enabled.
    }

    private void OnDisable()
    {
        movement.Disable();
        // Answer 6.2
        // OnDisable() is called when the object becomes disabled or inactive.
        // In this example, it is called when the script is disabled.
        // And players can't move the character when the script is disabled.
    }
}