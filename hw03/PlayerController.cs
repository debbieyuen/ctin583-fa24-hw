// TODO: Problem 1: Write in the comments what each line of code is doing.
// What is "using" and what is System.Collections? Please provide comments on what the next three lines mean. 

//using allows us to import the namespace which gives us access to the classes, data types, etc in each specific library without having to qualify each one.
using System.Collections; //includes IEnumerator interace which allows us to do coroutines
using System.Collections.Generic; //incldues various types like List, Dictionary, etc.
using UnityEngine; //allows us to access Unity's classes like GameObject, their phsyics, etc.

public class PlayerController : MonoBehaviour
{
    /* 
    TODO: Problem 2: We are trying to move our player in an open world game. We would like the player to be able to move
    foward, backward, left, and right. In addition, the player should be able to jump and adapt to the world's gravity.
    First, we will need to define some variables in order to control our player with the WASD keys and the Space bar for it to jump. 
    Please define the following private variables and print them out to Unity's console: 

    
                1. Player or Character's Name // private string playerName = "Player";
                2. Movement Speed as a float // private float moveSpeed = 10f;
                3. Gravity Value as a float //private float gravityValue = 2f;
                4. Jump Speed as a float // private float jumpSpeed = 5f;

to print these out in the unity console you would write Debug.Log and the variable name i.e. Debug.Log(moveSpeed) or Debug.Log(playerName); within the start function
//to print all at once you can use concatenation and type Debug.Lug (playerName + moveSpeed + gravityValue + jumpSpeed);
    
    When the game starts, we would like to find our character. In our Unity Editor, we have a 3D model of our player and the player is 
    represented as a component in Unity. How do we grab our player controller in code and where should we write this line of code in this
    C# document (PlayerController.cs)?
    
    //I'm not sure if I understand this correctly but to have the script reference the player game object in unity under where the other variables were declared you would write: public GameObject player; 
    
    // Start is called before the first frame update
    void Start()
    {
        // TODO: Problem 3: Describe when you would put code in the Start() function instead of the Update() function. 
            // Since the start function is only called once at the start of the game it's good to use for things that only need to be done once like declaring variables initial start values like player lives or score
        
            
        // What is the difference between Start() and Update()?
            // start is only called once when the game first starts and update is called with each frame (so if you have 60fps its called 60 times in a second)
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Problem 4: What is an if statement? Write a couple of if statements to move the player with the WASD keys. 
            //an if statement checks if a condition is met before executing a certain line of code.
            /* ex:
                if (Input.GetKey(KeyCode.D))
                {
                    transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
                }

                if (Input.GetKey(KeyCode.A))
                {
                    transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
                }

            */
        // We want to transform the player's position along the vertical and horizontal axis then multiply it by 
        // the corresponding variables we defined earlier. Lastly, we will need to multiply it all by Time.DeltaTime
    }

    // TODO: Problem 5: What do the lines here do? Please provide inline comments and describe what each line is doing
    // What do Header, SerializeField, and Tooltip mean? 
    [Header("General Setup Settings")] //this creates a new label in the inspector called "General Setup Settings" above the below variables
    [SerializeField] private InputAction movement; //this is allowing the private variable movement to be accessed in Unity
    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f; //this line makes it so in Unity when you hover over ControlSpeed it will display the text in the parenthesis and serialized field is making it so the variable can be accessed in Unity
    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f; //gives info in parenthesis when hover over xRange and lets you edit the value in Unity
    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f; //gives info in parenthesis when hover over yRange and lets you edit the value in Unity
    
//Header  allows you to display a new label in the Unity inspector above a variable group and is useful in organizing related variables in your project
//Tooltip creates a small popup to display additional information to the user when you hover over it
//SerializeField allows private variables to show and be edited in the Unity inspector

    // TODO: Problem 6: What are Unity's OnEnable() and OnDisable functions? 
        //OnEnable is a function that is called when the object first becomes enabled and active (i.e. when you run the game)
        //OnDisable is a function called when the behavior becomes disabled. Called when object is destroyed.
    // What do movement.Enable() and movement.OnDisable do?
    private void OnEnable()
    {
        movement.Enable(); //this is making sure the InputAction called movement is enabled and checking for input when the game runs. Without it, the input action would not trigger any movement logic
    }

    private void OnDisable()
    {
        movement.Disable(); //this makes it so once the object is destroyed or gone the system is not checking for input from it
    }
}
