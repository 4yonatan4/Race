using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LifeSystem : MonoBehaviour
{
    public GameObject player;
    public AudioSource obstacleSound;

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.name == "Player")
        {
            Debug.Log("HIT");
            obstacleSound.Play();
            player.GetComponent<Player>().life--;
            Destroy(gameObject);
        }
    }
}