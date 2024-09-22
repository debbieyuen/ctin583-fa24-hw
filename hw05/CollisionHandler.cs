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
        // Structs can have members and methods. A tuple can only have labels and values. So tuples are 
        // better for quick grouping of values. 

        * How do we access items in a tuple?
        // Items in a tuple can be accessed using the dot operator. By default, items are labeled Item1
        // Item2, and so on. For example, items in tuple t1 can be accessed as t1.Item1, t1.Item2, etc.

        * Try visualizing your enum in the Unity Editor. How does it appear as?
        // Enums appear as dropdowns in the Unity Editor
        
******************************************************************************************************
*/
public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private ParticleSystem enemyParticles;
    [SerializeField] private CollectibleItems collectibles;

    private void OnCollisionEnter(Collision collision)
    {
        // Problems 1 & 2
        switch (collectibles)
        {
\            case CollectibleItems.Bomb:
                Destroy(gameObject);
                break;

            case CollectibleItems.Rock:
                Destroy(gameObject);
                break;

            case CollectibleItems.Gem:
                meshRenderer.material = collision.gameObject.GetComponent<Renderer>().material;
                Destroy(collision.gameObject);
                PlayParticles();
                break;

            case CollectibleItems.Leaf:
                Destroy(gameObject);
                break;

            case CollectibleItems.Flower:
                Destroy(gameObject);
                break;
            
            case CollectibleItems.Fake:
                Destroy(gameObject);
                break;

            case CollectibleItems.Enemy:
                Destroy(gameObject);
                break;

            case CollectibleItems.Player:
                Destroy(gameObject);
                break;

            default:
                break;
        }
    }

    // Problem 3
    void Tuples()
    {
        // Value tuples are useful for combining multitples values into a single element.

        (int, int, string) t1 = (1, 2, "Buckle my shoe");
        Debug.Log(t1);

        var t2 = (3, 4, "Shut the door");
        Debug.Log(t2);
    }

    // Problem 4
    enum ParticleTypes
    {
        FireParticles,
        GoldRibbons,
        Snowflakes,
        RainParticles
    }
}
