using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public Vector3 force;
    public Vector3 relativeForce;
    // Start is called before the first frame update
    public void Start()
    {
    }

    // Update is called once per frame
    public void Update()
    {
        if (Time.time > 3f)
        {
            ConstantForce.Destroy(this);
        }
    }
}