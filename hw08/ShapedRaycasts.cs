using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShapedRaycsts : MonoBehaviour
{
    Ray ray;
    public Vector3 position1 = new Vector3(0,-2,0); 
    public Vector3 position2 = new Vector3(0,2,0);

    void Start()
    {
        ray = new Ray(transform.position, transform.forward);
        CheckForColliders();

    }
    void CheckForColliders()
    {
        if (Physics.CapsuleCast(position1, position2, 0.5f, transform.forward))
        {
            Debug.Log("Something was hit!");
        }
    }
}