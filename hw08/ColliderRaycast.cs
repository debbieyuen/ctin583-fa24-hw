using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColliderRaycast : MonoBehaviour
{
    public Collider colliderToHit;
   Ray ray;

    void Start()
    {
        ray = new Ray(transform.position, transform.forward);
        CheckForColliders();

    }
    void CheckForColliders()
    {
        if (colliderToHit.Raycast(ray, out RaycastHit hit, 100))
        {
            Debug.Log("The Orange Cube was hit!");
        }
    }
}