using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneRaycast : MonoBehaviour
{
    Plane Plane = new Plane(Vector3.down, 0);
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Plane.Raycast(ray, out float distance))
        {
            transform.position = ray.GetPoint(distance);
        }
    }

}
