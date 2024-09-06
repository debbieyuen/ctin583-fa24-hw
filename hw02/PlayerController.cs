// TODO: Problem 1: Write in the comments what each line of code is doing.
// What is "using" and what is System.Collections? Please provide comments on what the next three lines mean. 
using System.Collections;
//directive for a particular namespace which are being used in that script
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

    We can create a new folder in Assets and name it "Scripts". 
    Then create a new C# script and write "PlayerController.cs" document in it. 
    Lastly drag this script to the inspector of 3D model as a component in Unity.
    */


    // Declaring a variable
    string username;
    // Assigning a value to a variable
    username = Console.ReadLine();
    // Retrieving its current value
    Console.WriteLine("My player's name is " + Arikaka);
    private float Speed;
    private float Gravity Value;
    private float Jump Speed;
    void Start()
    {
        // TODO: Problem 3: Describe when you would put code in the Start() function instead of the Update() function. 
        // What is the difference between Start() and Update()?
    }
    /* Start is called before the first frame update
      Update is called once per frame
    */
    void Update()
    {
        // TODO: Problem 4: What is an if statement? Write a couple of if statements to move the player with the WASD keys. 
        // We want to transform the player's position along the vertical and horizontal axis then multiply it by 
        // the corresponding variables we defined earlier. Lastly, we will need to multiply it all by Time.DeltaTime
        Vector2 inputVector = new Vector2(0, 0);
        if (Input.GetKeyDown(KeyCode.W))
        {
            inputVector.y = +1;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            inputVector.y = -1;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            inputVector.x = -1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            inputVector.x = +1;
        }
        inputVector = inputVector.normalized;
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.position += moveDir * moveSpeed * Time.deltaTime;
    }

    // TODO: Problem 5: What do the lines here do? Please provide inline comments and describe what each line is doing
    // What do Header, SerializeField, and Tooltip mean? 
    [Header("General Setup Settings")]
    //a header is a section header created using the Header attribute in the Inspector. This attribute helps organize variables in the Inspector, making it easier and faster to use.
    [SerializeField] private InputAction movement;
    //[SerializeField] attribute is used to make the private variables accessible within the Unity editor without making them public .
    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f;
    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f;
    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f;
    //tooltips are a way to provide information to users about fields, classes, structs, and properties.

    // TODO: Problem 6: What are Unity's OnEnable() and OnDisable functions?
    /*OnEnable() is called again on disabled objects when SetActive(true) is called. 
     OnDisable() happens when you use SetActive(false) on the object.
    */
    // What do movement.Enable() and movement.OnDisable do?
    private void OnEnable()
    {
        movement.Enable();
        //Enable objects' Movement function
    }

    private void OnDisable()
    {
        movement.Disable();
        //Disable objects' Movement function
    }
}