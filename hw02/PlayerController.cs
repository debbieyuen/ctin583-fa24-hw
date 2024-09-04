// TODO: Problem 1: Write in the comments what each line of code is doing.
// What is "using" and what is System.Collections? Please provide comments on what the next three lines mean. 

//ANSWER: "using" directives allow for the use of a collection of classes 
using System.Collections;// ANSWER: Contains interfaces and classes that define various collections of objects, such as lists, queues, bit arrays, hash tables, and dictionaries
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
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

    ANSWER: We should use the GetComponent function and we would want to use this on either the Start method or more preferably we would use the Awake method.
    */

    private string PlayerName;
    private float MoveSpeed;
    private float GravValue;
    private float JumpSpeed;
    // Start is called before the first frame update
    void Start( ) {
        Debug.Log( PlayerName );
        Debug.Log( MoveSpeed );
        Debug.Log( GravValue );
        Debug.Log( JumpSpeed );


        // TODO: Problem 3: Describe when you would put code in the Start() function instead of the Update() function. 
        // What is the difference between Start() and Update()?
        //ANSWER: We would use the Start() function when we want code to be run at the start of our game and run only once.
        //ANSWER: We would use the Update() function when we want to run and check code every frame.
        //Answer: Start() only runs once and Update() is run every frame
    }

    // Update is called once per frame
    void Update( ) {
        // TODO: Problem 4: What is an if statement? Write a couple of if statements to move the player with the WASD keys. 
        // We want to transform the player's position along the vertical and horizontal axis then multiply it by 
        // the corresponding variables we defined earlier. Lastly, we will need to multiply it all by Time.DeltaTime

        if(Input.GetKeyDown( KeyCode.W )) {
            transform.position += Vector3.forward * MoveSpeed * Time.deltaTime;
        }
        if(Input.GetKeyDown( KeyCode.A )) {
            transform.position += Vector3.left * MoveSpeed * Time.deltaTime;
        }
        if(Input.GetKeyDown( KeyCode.S )) {
            transform.position += Vector3.back * MoveSpeed * Time.deltaTime;
        }
        if(Input.GetKeyDown( KeyCode.D )) {
            transform.position += Vector3.right * MoveSpeed * Time.deltaTime;
        }
    }

    // TODO: Problem 5: What do the lines here do? Please provide inline comments and describe what each line is doing
    // What do Header, SerializeField, and Tooltip mean? 
    [Header( "General Setup Settings" )]
    //ANSWER: this will display a line of text to help organize defined variables
    [SerializeField] private InputAction movement;
    // ANSWER: This will allow this private variable to appear in the editor to be modified
    [Tooltip( "How fast player moves up and down based upon player input" )] [SerializeField] float controlSpeed = 30f;
    // ANSWER: Tooltip will display any text you want when hovering over the Serialized field "controlSpeed" in the editor
    [Tooltip( "How far player moves horizontally" )] [SerializeField] float xRange = 10f;
    //ANSWER: Will allow the xRange to be editted in the editor and will display "How far player moves horizontally" when hovering over
    [Tooltip( "How far player moves vertically" )] [SerializeField] float yRange = 10f;
    //ANSWER: Will allow the yRange to be editted in the editor and will display "How far player moves vertically" when hovering over


    // TODO: Problem 6: What are Unity's OnEnable() and OnDisable functions?
    // What do movement.Enable() and movement.OnDisable do?
    //ANSWER: OnEnable() and OnDisable() is called when the gameobject is either enabled/active or when the object is disabled/destroyed
    //ANSWER: movement is a variable of type "InputAction" and this variable handles all input recieved, enabling and disabling will toggle if input will work on player movement
    private void OnEnable( ) {
        movement.Enable();
    }

    private void OnDisable( ) {
        movement.Disable();
    }
}