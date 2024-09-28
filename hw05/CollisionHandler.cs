using System.Diagnostics;
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

    // Normal tuple
    var tuple = new Tuple<int, string>(1, "Bomb");

    // Value tuple
    var valueTuple = (index: 1, item: "Bomb");

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case CollectibleItems.Enemy:
                Destroy(gameObject);
                break;

            case CollectibleItems.Gem:
                meshRenderer.material = collision.gameObject.GetComponent<Renderer>().material;
                Destroy(collision.gameObject);
                PlayParticles();
                break;

            // Add other cases similarly using the enum values
            case CollectibleItems.Bomb:
                Destroy(gameObject);
                break;

            case CollectibleItems.Rock:
                Destroy(gameObject);
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

            case CollectibleItems.Player:
                Destroy(gameObject);
                break;

                Destroy(gameObject);
                break;

            default:
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
        Debug.log(tuple)
    }
}
