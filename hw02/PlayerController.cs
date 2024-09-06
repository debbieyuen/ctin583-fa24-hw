// TODO: Problem 1: Write in the comments what each line of code is doing.
// What is "using" and what is System.Collections? Please provide comments on what the next three lines mean. 
// by inlcuding “using“ with different namespaces after it, you can use those functions, classes, functions, or other organized logically by just calling their namesapce in this script, and the conputer will know what todo.
using System.Collections; // This namesapce included lots of useful things like lists, queues, bit arrays, hash tables, and dictionaries.
using System.Collections.Generic; // Is a Generic collection, which allow me to use things like compare<T> and Dictionary.
using UnityEngine; // It contain core function namespaces in Unity Engine, like variable type, GameObject.
using UnityEngine.InputSystem; // Is a namespace could help to user to use different ways like device, gestures, and touch to control the game obejct.

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

    public string characterName;
    public float speed;
    public float gravityValue;
    public float jumpSpeed;
    public PlayerController myPlayerController;

    // Start is called before the first frame update
    private void Start()
    {
        // Answer: myPlayerController = GameObject.Find("Player").GetComponent<PlayerController>();
        // TODO: Problem 3: Describe when you would put code in the Start() function instead of the Update() function. 
        // Answer: The part of the game when you want the code to run when the game start but not want they update each frame.
        // What is the difference between Start() and Update()?
        // Answer: The Start() will only run when the game start, the Update() will run each frame during the game running to make sure everything update ontime.
    }

    // Update is called once per frame
    private void Update()
    {
        // TODO: Problem 4: What is an if statement? Write a couple of if statements to move the player with the WASD keys. 
        // Answer: A if statement is you run the script only when the if condition satisfied.
        // We want to transform the player's position along the vertical and horizontal axis then multiply it by 
        // the corresponding variables we defined earlier. Lastly, we will need to multiply it all by Time.DeltaTime

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 5) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -5) * Time.deltaTime);
        }
        //Debug.Log(Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-5, 0, 0) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(5, 0, 0) * Time.deltaTime);
        }
    }

    // TODO: Problem 5: What do the lines here do? Please provide inline comments and describe what each line is doing
    // What do Header, SerializeField, and Tooltip mean? 
    [Header("General Setup Settings")] // In the Inspector add UI with Header looking style, to help increase the readibility.
    [SerializeField] private InputAction movement; // To make private variable to displayable and editable in Unity Inspector.
    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f; // When your mouse hover on the variable controlSpeed, it will show the tip.
    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f; // When your mouse hover on the variable xRange, it will show the tip.
    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f; // When your mouse hover on the variable yRange, it will show the tip.

    // TODO: Problem 6: What are Unity's OnEnable() and OnDisable functions?
    // OnEnable() is activate the input action and OnDisable is diactivate the input action
    // What do movement.Enable() and movement.OnDisable do?
    // movement.Enable() will enable the movement input action, the movement.OnDisable will stop the movement input action.
    private void OnEnable()
    {
        movement.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
    }
}