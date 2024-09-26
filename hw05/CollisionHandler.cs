using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SearchService;

/* 
******************************************************************************************************
    Problem 1: TODO: Finish the case statements for each collectible item listed in CollectibleItems.cs

    Problem 2: TODO: Currently each case statement is written as a string. Enums are especially helpful 
    in preventing spelling mistakes. Instead of using strings sucn as "Enemy" and "Gem", lets use an enum. 
    Please modify each case statement to use an enum instead. 

    Problem 3: TODO: Define a normal tuple and a value tuple. When would you use a value tuple? 
    Print out each value in your defined tuple with Debug.Log

    Problem 4: TODO: Define a new enum within this file taking in different types of particles. 
    Examples include: FireParticles, GoldRibbons, Snowflakes, RainParticles, etc. 

    Problem 5: TODO: 
        * When would you use a tuple over a struct?
        * How do we acces items in a tuple?
        * Try visualizing your enum in the Unity Editor. How does it appear as?
        
******************************************************************************************************
*/
public class CollisionHandler : MonoBehaviour, CollectableInterface
{
    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private ParticleSystem enemyParticles;
    [SerializeField] private CollectibleItems collectibles; 


//Problem 4
public enum Particles {
    FireParticles = 1,

    GoldRibbons = 2,

    Snowflakes = 3,
    
    RainParticles = 4,

    BarfParticles = 5,

    DiamondParticles = 6
}



    private void OnCollisionEnter(Collision collision) {

        //Problem 1 and 2
        switch (collision.gameObject.tag) {
            
            case: CollectibleItems.Bomb:
                Destroy(gameObject);
                break;
            
            case: CollectibleItems.Rock:   
                Destroy(gameObject);
                break;

             case CollectibleItems.Gem:
                meshRenderer.material = collision.gameObject.GetComponent<Renderer>().material;
                Destroy(collision.gameObject);
                PlayParticles();
                break;

            case: CollectibleItems.Leaf:   
                Destroy(gameObject);
                break;  

            case: CollectibleItems.Flower:  
                Destroy(gameObject);
                break;
            
            case: CollectibleItems.Fake:       
                Destroy(gameObject);
                break;

            case CollectibleItems.Enemy:
                Destroy(gameObject);
                break;

            
            case: CollectibleItems.Player:     
                Destroy(gameObject);
                break;

            default:
                break;
        }
    }

    // Check to make sure our value is defined
    private bool IsCollectibleItem(CollectibleItems collectible) {
        return (collectibles & collectible) != 0;
    }

    // Start is called before the first frame update
    void Start()
    {


        // Problem 3
        // Normal Tuple
        var collisionTuple = new Tuple<int, string>(3, "No more collisions");

        // Value Tuple
        (int, int, string) timesCollionsCanHappen = (3, 4, "No more collisions");



        // Set the tag based on the enum
        gameObject.tag = collectibles.ToString();
    }
}


// Problem 5
// When would you use a tuple over a struct?
    //Tuples are used when you want to return multiple values. They are lightweight and wouldn't be used for complex data structures. 
    //Structs are used when you want to create a complex data structure. You'd use structs when you want to creat a new type that can be passed around in your code.

// How do we acces items in a tuple?
    //By using the dot operator- for example Tuple.Item1, Tuple.Item2, etc.

// Try visualizing your enum in the Unity Editor. How does it appear as?
    //Enums appear as dropdowns in the Unity Editor. You can select the enum you want in the inspector.