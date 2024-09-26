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
    I have no idea what a tuple is and I tried to search online but I'm still confused

    Problem 4: TODO: Define a new enum within this file taking in different types of particles. 
    Examples include: FireParticles, GoldRibbons, Snowflakes, RainParticles, etc. 

    Problem 5: TODO: 
        * When would you use a tuple over a struct?
        * How do we acces items in a tuple?
        * Try visualizing your enum in the Unity Editor. How does it appear as?
 *
 * According to google, a struct is more formal and reusable than a tuple,where a tuple is typically used for temporary groupings of data
       For normal tuples (using the Tuple class), you access items using the Item1, Item2. 
******************************************************************************************************
*/
public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private ParticleSystem enemyParticles;
    [SerializeField] private CollectibleItems collectibles; 

    private void OnCollisionEnter(Collision collision) {
        switch (collision.gameObject.tag) {
            case collectibles.Enemy:
                Destroy(gameObject);
                break;

            case collectibles.Gem:
                meshRenderer.material = collision.gameObject.GetComponent<Renderer>().material;
                Destroy(collision.gameObject);
                PlayParticles();
                break;
            case collectibles.Rock:
                break;
            case collectibles.Bomb:
                break;
            case collectibles.Leaf:
                break;
            case collectibles.Flower :
                break;
            case collectibles.Fake :
                break;
            case collectibles.Player :
                break;

            default:
                break;
        }
    }
    
    public enum ParticleSystems
    {
        FireParticles,
        GoldRibbons,
        SnowFlakes,
        RainParticles
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
