﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeSlider : MonoBehaviour
{
    public void OnValueChanged(float value)
    {
        Debug.Log(("New Value " + value));
    }
}