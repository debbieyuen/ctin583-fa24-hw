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

    Normal Tuple - A normal tuple in C# is a reference type and is created using the Tuple<T1, T2, ...> class. 
    It is less efficient because it stores values as objects and incurs boxing/unboxing overhead for value types.

    Value Tuple - A value tuple is a more lightweight, struct-based tuple introduced in C# 7.0. It provides better 
    performance, especially for value types, because it avoids the boxing/unboxing issues and is a value type itself. 
    Value tuples are typically used for performance-critical scenarios and are more flexible and convenient, particularly 
    for temporary or lightweight data structures.

    private void Start()
    {
        // Define a normal Tuple
        var normalTuple = new Tuple<int, string, bool>(1, "Gem", true);

        // Define a ValueTuple
        (int id, string name, bool isActive) valueTuple = (2, "Enemy", false);

        // Print each value of the normal Tuple
        Debug.Log($"Normal Tuple: ID = {normalTuple.Item1}, Name = {normalTuple.Item2}, IsActive = {normalTuple.Item3}");

        // Print each value of the ValueTuple
        Debug.Log($"Value Tuple: ID = {valueTuple.id}, Name = {valueTuple.name}, IsActive = {valueTuple.isActive}");
    }

    Problem 4: TODO: Define a new enum within this file taking in different types of particles. 
    Examples include: FireParticles, GoldRibbons, Snowflakes, RainParticles, etc. 

    Problem 5: TODO: 
        * When would you use a tuple over a struct?
        Tuples - Use a tuple when you want a lightweight and simple grouping of multiple values that doesn't require named fields or complex behavior. 
        Tuples are usually used for returning multiple values from a method or for quick data grouping without needing a formal structure.
        Struct - Use a struct when you need a more complex data type with named fields, methods, or behavior. Structs are ideal when the data has meaning, and you need to encapsulate related fields together with potential functionality.
        
        *How do we acces items in a tuple?
        Items in a tuple can be accessed using positional properties like Item1, Item2, etc., or with named fields if they are provided.
        For eg. -
        // Positional Tuple
        var myTuple = (1, "Gem", true);
        Debug.Log(myTuple.Item1);  // Output: 1
        Debug.Log(myTuple.Item2);  // Output: Gem
        Debug.Log(myTuple.Item3);  // Output: true

        // Named Tuple
        var namedTuple = (id: 2, name: "Enemy", isActive: false);
        Debug.Log(namedTuple.id);         // Output: 2
        Debug.Log(namedTuple.name);       // Output: Enemy
        Debug.Log(namedTuple.isActive);   // Output: false
     
        * Try visualizing your enum in the Unity Editor. How does it appear as?
        When we define an enum in Unity and serialize it with the [SerializeField] attribute, it will appear in the Unity Editor as a dropdown menu. Each option in the dropdown corresponds to the values defined in your enum.

        
******************************************************************************************************
*/
using UnityEngine;

// Enum to define different types of particles
public enum ParticleTypes
{
    FireParticles,
    GoldRibbons,
    Snowflakes,
    RainParticles,
    Sparkles,
    Confetti
}

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private ParticleSystem enemyParticles;
    [SerializeField] private CollectibleItems collectibles;
    [SerializeField] private ParticleTypes particleType;  // New enum for particle types

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Enemy":
                Destroy(gameObject);
                break;

            case "Gem":
                meshRenderer.material = collision.gameObject.GetComponent<Renderer>().material;
                Destroy(collision.gameObject);
                PlayParticles();
                break;

            default:
                break;
        }
    }

    // Method to play particles based on the selected ParticleType
    private void PlayParticles()
    {
        switch (particleType)
        {
            case ParticleTypes.FireParticles:
                Debug.Log("Playing Fire Particles");
                break;
            case ParticleTypes.GoldRibbons:
                Debug.Log("Playing Gold Ribbons");
                break;
            case ParticleTypes.Snowflakes:
                Debug.Log("Playing Snowflakes");
                break;
            case ParticleTypes.RainParticles:
                Debug.Log("Playing Rain Particles");
                break;
            case ParticleTypes.Sparkles:
                Debug.Log("Playing Sparkles");
                break;
            case ParticleTypes.Confetti:
                Debug.Log("Playing Confetti");
                break;
            default:
                Debug.Log("No particle effect defined.");
                break;
        }
    }

    // Check if the collectible item is defined
    private bool IsCollectibleItem(CollectibleItems collectible)
    {
        return (collectibles & collectible) != 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.tag = collectibles.ToString();

        // Define a normal Tuple
        var normalTuple = new Tuple<int, string, bool>(1, "Gem", true);

        // Define a ValueTuple
        (int id, string name, bool isActive) valueTuple = (2, "Enemy", false);

        // Print each value of the normal Tuple
        Debug.Log($"Normal Tuple: ID = {normalTuple.Item1}, Name = {normalTuple.Item2}, IsActive = {normalTuple.Item3}");

        // Print each value of the ValueTuple
        Debug.Log($"Value Tuple: ID = {valueTuple.id}, Name = {valueTuple.name}, IsActive = {valueTuple.isActive}");
    }
}
