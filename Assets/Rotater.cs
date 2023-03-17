using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    public float rotationSpeed = 0.3f;
    public bool rotate = true;
    void FixedUpdate() //use for constant updates
    {
        if (rotate)
        {
            this.GetComponent<Transform>().Rotate(0, rotationSpeed, 0.1f);
        }


    }
}
