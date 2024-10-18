using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Raycast2DExamples : MonoBehaviour
{

    void Start()
    {
        RaycastHit2D raycastHit2D = Physics2D.Raycast(transform.position, Vector3.right);
        if (raycastHit2D)
        {
            Debug.Log("Something was hit!");
        }
    }
}