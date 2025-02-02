// TODO: Problem 1: Write in the comments what each line of code is doing.
// What is "using" and what is System.Collections? Please provide comments on what the next three lines mean. 

// "using" allows us to access classes and methods from namespaces
using System.Collections; // contains interfaces and classes for non-generic collections (ArrayList, Queue, etc)
using System.Collections.Generic; // contains interfaces and classes for generic collections (List<T>, Dictionary<T, K>, etc) (generic collections are more type safe and do not require type casting)
using UnityEngine; // contains classes specific to unity for game development (MonoBehavior, GameObject, etc)

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

    // private variables
    private string playerName = "Character";
    private float movementSpeed = 5.0f;
    private float gravityValue = -9.81f;
    private float jumpSpeed = 8.0f;

    // declare a variable of type CharacterController
        private CharacterController controller;
    
    // Start is called before the first frame update
    void Start()
    {
        // run once, put it at beginning of Start() to ensure all components are ready
        controller = GetComponent<CharacterCOntroller>

        // print out to Unity's console
        Debug.Log("Player Name: " + playerName);
        Debug.Log("Movement Speed: " + movementSpeed);
        Debug.Log("Gravity Value: " + gravityValue);
        Debug.Log("Jump Speed: " + jumpSpeed);

        // TODO: Problem 3: Describe when you would put code in the Start() function instead of the Update() function. 
        // What is the difference between Start() and Update()?

        // Put code in Start() when initializing variables, getting components, setting up initial game state, etc
        // This is because Start() is only called once when the script is first being executed

        // Put code in Update() for any behavior/actions that need to be updated every frame, such as movement, physics, input, etc
        // This is because Update() is called every frame

    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Problem 4: What is an if statement? Write a couple of if statements to move the player with the WASD keys. 
        // We want to transform the player's position along the vertical and horizontal axis then multiply it by 
        // the corresponding variables we defined earlier. Lastly, we will need to multiply it all by Time.DeltaTime

        // An if statement sections a piece of code with a condition; if the condition is satisfied, then the code will execute
        float horizontalInput = Input.GetAxis("Horizontal"); // get input value (-1 to 1) for horizontal (a/d) movement
        float verticalInput = Input.GetAxis("Vertical"); // get input value (-1 to 1) for vertical (w/s) movement

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput); // create movement vector by combining horizontal and vertical input into 3D vector

        vector3 movementAmt = movement * movementSpeed * Time.deltaTime; // apply movement speed to movement and make it independent of frame-rate (for consistent speed)

        controller.Move(movementAmt); // move controller, moves the character

        if(verticalInput.GetKeyDown(KeyCode.Space && controller.isGrounded) ) { // checks for jump input; if space is pressed and character is on ground
            movementAmt.y = jumpSpeed; // apply jump force
        }

        if(!controller.isGrounded) { // apply gravity; if character is in air
            movementAmt.y += gravityValue * Time.deltaTime; // pull character down
        }
    }

    // TODO: Problem 5: What do the lines here do? Please provide inline comments and describe what each line is doing
    // What do Header, SerializeField, and Tooltip mean? 
    [Header("General Setup Settings")] // creates a header in Unity Inspector to group variables for better oganization
    [SerializeField] private InputAction movement; // makes private variables visible in Unity Inspector
    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f;4    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f; // displays tooltip in Unity Inspector to explain what variable does
    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f; // displays tooltip in Unity Inspector to explain what variable does

    // TODO: Problem 6: What are Unity's OnEnable() and OnDisable functions?
    // What do movement.Enable() and movement.OnDisable do?
    private void OnEnable() // called when script is enabled or the GameObject is activated
    {
        movement.Enable(); // enables input system to start receiving player inputs
    }

    private void OnDisable() // called when script is disabled or GameObject is activated
    {
        movement.Disable(); // disables input system to stop receiving inputs when player is inactive
    }
}