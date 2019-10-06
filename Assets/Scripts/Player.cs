using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int score = 0;
    public int life = 3;

    public GameObject scoreText;
    public GameObject lifeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = "SCORE: " + score;
        lifeText.GetComponent<TextMeshProUGUI>().text = "LIFE: " + life;
        if (life == 0)
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene("GameOver");
        }
    }
}
