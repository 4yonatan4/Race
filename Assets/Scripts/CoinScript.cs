﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(5, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}