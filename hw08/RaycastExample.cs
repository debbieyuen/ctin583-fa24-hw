using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RaycastExample : MonoBehaviour
{
    Ray ray;
    float maxDistance = 100;
    public LayerMask layersToHit;

    void Start()
    {
        ray = new Ray(transform.position, transform.forward);
        CheckForColliders();

    }
    void CheckForColliders()
    {
        if (Physics.Raycast(ray, out RaycastHit hit, maxDistance, layersToHit))
        {
            Debug.Log("The Orange Cube was hit!");
        }
    }
}