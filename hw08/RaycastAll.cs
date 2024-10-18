using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RaycastAll : MonoBehaviour
{
    Ray ray;
    RaycastHit[] hits = new RaycastHit[5];

    void Start()
    {
        ray = new Ray(transform.position, transform.forward);
        CheckForColliders();

    }
    void CheckForColliders()
    {
       int numHits = Physics.RaycastNonAlloc(ray, hits);
        if (numHits > 0)
        {
            for (int i = 0; i< numHits; i++)
            {
                Debug.Log(hits[i].collider.gameObject.name);
            }
        }
    }
}