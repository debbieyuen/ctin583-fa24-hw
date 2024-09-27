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
            Value tuples are more efficient for short-lived data structures, as they don't require heap allocation.
            You can name the elements, making the code more self-documenting. When you want to return multiple values from a method without defining a specific class.
            Local variables: For temporary grouping of related data within a method. Value tuples support easy deconstruction, which is useful for unpacking multiple return values.

    Problem 4: TODO: Define a new enum within this file taking in different types of particles. 
    Examples include: FireParticles, GoldRibbons, Snowflakes, RainParticles, etc. 

    Problem 5: TODO: 
        * When would you use a tuple over a struct?
               when I need to return multiple values from a method without defining a specific class.
        * What is the difference between a tuple and a struct?
                A tuple is a data structure that has a specific number and sequence of elements. A struct is a value type that can contain constructors, constants, fields, methods, properties, indexers, operators, events, and nested types.
        * How do we acces items in a tuple?
                By using the Item1, Item2, Item3, and Item4 properties.
        * Try visualizing your enum in the Unity Editor. How does it appear as? 
                It appears as a dropdown list in the Unity Editor.
        
******************************************************************************************************
*/
[Flags]
public enum CollectibleItems
{
    Bomb = 1,
    Rock = 2,
    Gem = 3,
    Leaf = 4,
    Flower = 5,
    Fake = 6,
    Enemy = 7,
    Player = 8
}

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private ParticleSystem enemyParticles;
    [SerializeField] private CollectibleItems collectibles; 

    private void OnCollisionEnter(Collision collision) {
        CollectibleItems collidedItem;
        switch (collidedItem) {
            case CollectibleItems.Enemy:
                Destroy(gameObject);
                break;

            case CollectibleItems.Gem:
                meshRenderer.material = collision.gameObject.GetComponent<Renderer>().material;
                Destroy(collision.gameObject);
                PlayParticles();
                break;
            case CollectibleItems.Enemy:
                Destroy(collision.gameObjec);
                break;
            case CollectibleItems.Leaf:
                Destroy(collision.gameObjec);
                break;
             case CollectibleItems.Flower:
                Destroy(collision.gameObjec);
                break;
             case CollectibleItems.Fake:
                Destroy(collision.gameObjec);
                break;
            case CollectibleItems.Player:
                Destroy(collision.gameObjec);
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
        // Set the tag based on the enum
        gameObject.tag = collectibles.ToString();
    }
}

public class Tuple1 : MonoBehaviour
{
    public void TupleExampleMethod()
    {
        // Define a normal tuple
        var normalTuple = new Tuple<string, int>("Bomb", 1);

        var valueTuple = (string: "Rock", int: 1);

        Debug.Log("Normal Tuple- Item1:" + normalTuple.Item1);
        Debug.Log("Value Tuple- Item2:" + valueTuple.Item2);

  
    }
}
public enum ParticleType
{
    FireParticles,
    GoldRibbons,
    Snowflakes,
    RainParticles
}
