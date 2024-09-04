// TODO: Problem 1: Write in the comments what each line of code is doing.
// What is "using" and what is System.Collections? Please provide comments on what the next three lines mean. 
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
// "using" is to import the following namespace. System.Collections allows you to use things such as Arraylist
// System.Collections.Generic allows you to use things such as List<T>
// unityengine provides access to the core unity components such as gameobject, transform,etc.

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

    private string username = "me";
    private float movespeed = 10f;
    private float gravity = 9.8f;
    private float jumpspeed = 2f;

    private CharacterController player;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(username);
        Debug.Log(movespeed);
        Debug.Log(gravity);
        Debug.Log(jumpspeed);
        player = GetComponent<CharacterController>();
        // TODO: Problem 3: Describe when you would put code in the Start() function instead of the Update() function. 
        // What is the difference between Start() and Update()?
        //Start() is called before the the first frame, and is only called once, update() is called each frame as the game runs.
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Problem 4: What is an if statement? Write a couple of if statements to move the player with the WASD keys. 
        // We want to transform the player's position along the vertical and horizontal axis then multiply it by 
        // the corresponding variables we defined earlier. Lastly, we will need to multiply it all by Time.DeltaTime
        Vector3 move = Vector3.zero;
        
        if (Input.GetKey(KeyCode.W)) 
        {
            move += transform.forward; 
        }
        if (Input.GetKey(KeyCode.S)) 
        {
            move -= transform.forward; 
        }
        if (Input.GetKey(KeyCode.A)) 
        {
            move -= transform.right; 
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            move += transform.right;
        }
        move = move.normalized * movespeed * Time.deltaTime;
        
        player.Move(move);
    }

    
// TODO: Problem 5: What do the lines here do? Please provide inline comments and describe what each line is doing
    // What do Header, SerializeField, and Tooltip mean? 
    [Header("General Setup Settings")] // Header addes a visible header to the unity inspector 
    [SerializeField] private InputAction movement; //makes the private variable visible in the inspector while still keeping it private from other scripts
    //Tooltip adds a small tooltip in the inspector when you hover over it, explaining each variable.
    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f;
    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f;
    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f;
    // TODO: Problem 6: What are Unity's OnEnable() and OnDisable functions?
    // What do movement.Enable() and movement.OnDisable do?
    
    //OnEnable() and Ondisable() allows you to manage what happens when a gameobject is activated or deactivated
    //movement.Enable() and disable() controls whether or not the player input is processed
    private void OnEnable()
    {
        movement.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
    }
}