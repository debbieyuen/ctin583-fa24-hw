// TODO: Problem 1: Write in the comments what each line of code is doing.
// What is "using" and what is System.Collections? Please provide comments on what the next three lines mean. 
using System.Collections; // "using" imports a namespace. The System.Collections namespace contains classes that define collections of objects like lists and arrays
using System.Collections.Generic; // this namespace contains classes with more generic collections like dictionary and KeyValuePair
using UnityEngine; //this namespace contains classes commonly used in scripting for Unity, like GameObject 
using UnityEngine.InputSystem; //I had to add this namespace to get InputAction to work

public class PlayerController : MonoBehaviour

{
    [SerializeField] string username = "Player 1"; 
    [SerializeField] float speed = 6f;
    [SerializeField] float gravity = 1f;
    [SerializeField] float jump = 3f;

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
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My  player's name is " + username);
        Debug.Log("My speed is " + speed);
        Debug.Log("The gravity value is " + gravity);
        Debug.Log("My  jump speed " + jump);
        // TODO: Problem 3: Describe when you would put code in the Start() function instead of the Update() function. 
        // What is the difference between Start() and Update()?

        // Start() is only called once, on initialization. It's used for loading things that don't need to constantly change.
        // Update() is called once per frame and is good for things that change, like transforming position.
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Problem 4: What is an if statement? Write a couple of if statements to move the player with the WASD keys. 
        // We want to transform the player's position along the vertical and horizontal axis then multiply it by 
        // the corresponding variables we defined earlier. Lastly, we will need to multiply it all by Time.DeltaTime

        if (Input.GetAxis("Vertical") != 0)
        {
            float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            transform.Translate(0, 0, translation);
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            float translation = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            transform.Translate(translation, 0, 0);
        }

    }

    // TODO: Problem 5: What do the lines here do? Please provide inline comments and describe what each line is doing
    // What do Header, SerializeField, and Tooltip mean? 

    // "Header" makes this text appear formatted as a header (large, bold) in the inspector
    [Header("General Setup Settings")] 

    // "SerializeField" makes the field appear in the inspector as an editable attribute within Unity
    [SerializeField] private InputAction movement; 
    // "Tooltip" makes a string appear in the inspector as hover text
    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f;
    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f;
    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f;

    // TODO: Problem 6: What are Unity's OnEnable() and OnDisable functions?
    // What do movement.Enable() and movement.OnDisable do?
    private void OnEnable() // OnEnable() is called when the object becomes active
    {
        movement.Enable(); // This function enables movement when the object becomes active
    }

    private void OnDisable() // OnDisable() is called when the object stops being active
    {
        movement.Disable(); // This function disables movement when the object stops being active
    }
}