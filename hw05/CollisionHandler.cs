using System;
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
public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private ParticleSystem enemyParticles;
    [SerializeField] private CollectibleItems collectibles;

    public enum ParticleTypes
    {
        FireParticles,
        GoldRibbons,
        Snowflakes,
        RainParticles
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collectibles)
        {
            case CollectibleItems.Enemy:
                Destroy(gameObject);
                break;

            case CollectibleItems.Gem:
                meshRenderer.material = collision.gameObject.GetComponent<Renderer>().material;
                Destroy(collision.gameObject);
                PlayParticles();
                break;

            case CollectibleItems.Bomb:
                break;

            case CollectibleItems.Leaf:
                break;

            case CollectibleItems.Rock:
                break;

            case CollectibleItems.Flower:
                break;

            case CollectibleItems.Fake:
                break;

            case CollectibleItems.Player:
                break;

            default:
                break;
        }
    }

    // Check to make sure our value is defined
    private bool IsCollectibleItem(CollectibleItems collectible)
    {
        return (collectibles & collectible) != 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Set the tag based on the enum
        gameObject.tag = collectibles.ToString();

        //normalTuple
        Tuple<int, float> normalTuple = new Tuple<int, float>(0, 1.0f);
        Debug.Log(normalTuple);

        //valueTuple
        (int, float)valueTuple = (0, 1.0f);
        Debug.Log(valueTuple);
        //value tuples are used whenever you don't want to create a new object for a tuple.
        //it is a more lightweight alternative to normal tuples

    }

    ///<summary>
    ///Question 5 answers:
    /// 
    /// You would use a tuple over a struct whenever you want a lightweight grouping of values with simple behavior
    /// Structs are better for more complex behavior, mirroing that of an object without the actual object title
    /// 
    /// You access items in a tuple the same way you would for any object; with the "." operator followed by the atrribute name
    /// 
    /// Marking an enum as SerializedField allows you to visualize enums in a drop down menu
    ///</summary>
}
