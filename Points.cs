using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{

    public Text scoreText;
    int Score = 0;
    void Update()
    {
        SetCountText();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            Score += 100;
        }
    }
    void SetCountText()
    {
        scoreText.text = "Score: " + Score.ToString();
    }
}
