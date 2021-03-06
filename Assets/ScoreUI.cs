﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public Text textObj;
    decimal score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        textObj = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerController.Lives > 0)
        {
            score += 1;
        }

        textObj.text = "Score " + score;
    }

    public void ResetScore()
    {
        score = 0;
    }
}
