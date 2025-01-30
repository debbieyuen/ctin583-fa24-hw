
//---------------------------------------------------------PROBLEM 1----------------------------------------------------------------//
// TODO: Problem 1: Write in the comments what each line of code is doing.
// What is "using" and what is System.Collections? Please provide comments on what the next three lines mean. 
using System.Collections;
// This line import the "System.Collections namespace", including ArrayList, Hashtag, etc. These are non-generic colection types, like a grocery store. They can store objects without spefiying a data type, but need to be very careful, otherwise it's easier to mixed up.
using System.Collections.Generic;
// The line imports the namespace "System.Collections.Generic", which is specifically referring to type (int, string, etc). It's safer to use.
using UnityEngine;
// After using UnityEngine, I'm allowed to use Unity and game related API functions, for example, MonoBehavior, GameObject and Transform.
// Using is like prepraing food and tools before cooking. Once the namespaces were imported, you can say "I need xxx" directly.





//---------------------------------------------------------PROBLEM 2----------------------------------------------------------------//
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
    private string playerName = "Ricky";  // Player's name
    private float movementSpeed = 8.0f;  // Movement speed
    private float gravity = 9.81f;       // Gravity value
    private float jumpSpeed = 3.0f;      // Jump speed

    void Start()
    {
        //Print out to Unity's Console
    Debug.Log("Player Name: " + playerName);
    Debug.Log("Movement Speed: " + movementSpeed);
    Debug.Log("Gravity: " + gravity);
    Debug.Log("Jump Speed: " + jumpSpeed);

        // Grab the player controller
        PlayerController player = GetComponent<PlayerController>();

    }






//---------------------------------------------------------PROBLEM 3----------------------------------------------------------------/
    // Start is called before the first frame update
    void Start()
    {
        // TODO: Problem 3: Describe when you would put code in the Start() function instead of the Update() function. 
        // What is the difference between Start() and Update()?
        
        //ANSWER: Start() is applied when I want to run once at the start of the game or the object is first created. For example, say "hi" to the gamer at the start.
        //I put Update() when I want to run every frame, constantly happening per second. I use Start () if I want something appearing only once.
    }
    // Update is called once per frame







//---------------------------------------------------------PROBLEM 4----------------------------------------------------------------//

    void Update()
    {
        // TODO: Problem 4: What is an if statement? Write a couple of if statements to move the player with the WASD keys. 
        // We want to transform the player's position along the vertical and horizontal axis then multiply it by 
        // the corresponding variables we defined earlier. Lastly, we will need to multiply it all by Time.DeltaTime

        //ANSWER: if statement is used when I need to check something is true or false, and I can set up different consequence based on true or false.
        //***statement that move the player with the WASD keys*** 
        void Update()
{
    // Get player current location
    Vector3 move = Vector3.zero;

    // W-front
    if (Input.GetKey(KeyCode.W))
    {
        move += Vector3.forward * movementSpeed;
    }

    // S-back
    if (Input.GetKey(KeyCode.S))
    {
        move += Vector3.back * movementSpeed;
    }

    // A-left
    if (Input.GetKey(KeyCode.A))
    {
        move += Vector3.left * movementSpeed;
    }

    // D-right
    if (Input.GetKey(KeyCode.D))
    {
        move += Vector3.right * movementSpeed;
    }

    // multiply by Time/DeltaTime
    transform.position += move * Time.deltaTime;
}

    }






//---------------------------------------------------------PROBLEM 5----------------------------------------------------------------//

    // TODO: Problem 5: What do the lines here do? Please provide inline comments and describe what each line is doing
    // What do Header, SerializeField, and Tooltip mean? 
    [Header("General Setup Settings")]
    //Header means showing the text "General Setup Settings" in the Unity Inspector, makes management clearer.

    [SerializeField] private InputAction movement;
    //SerializeField cooporate with private, made private variables can be changed in Unity Inspector while external script can't change them.
    //InputAction means player inpyt control, such us keyboard or joystick.

    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f;
    //Tooltip appears when mouse is placed on a variable.
    //The SerializeField defines the speed of player's movement, and the speed is 30f.

    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f;
    //Tooltip appears when mouse is hovering the string.
    //The maximum moving range for the player's right or left is 10f, which he or she can't cross the edge.

    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f;
    //The tooltip shows the sentence while hovering
    //The maximum moving range for the player's up and down is 10f, which he or she can't go over it.







//---------------------------------------------------------PROBLEM 6----------------------------------------------------------------//

    // TODO: Problem 6: What are Unity's OnEnable() and OnDisable functions?
    // What do movement.Enable() and movement.OnDisable do?
    private void OnEnable()
    //When turns on, execute related code

    {
        movement.Enable();
        //When the game object is active, movement.Enable starts listening for player inputs.
    }

    private void OnDisable()
    //When the object is destroyed or not allowed to use, execute related code
    {
        movement.Disable();
        //movement.Disable() stops listening for player inputs, preventing unwanted movement.

    }
}