using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    bool isGameOver;
    public GameObject Target;

    // Start is called before the first frame update
    void Start()
    {
        // If the game over UI is inactive, it doesn't activate itself in any condition.
        // therefore, I made a new empty object, GameManager,
        // and I make it manage a target, the game over UI.

        isGameOver = false;
        Target.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Activate Game Over UI
        if(PlayerController.Lives <= 0 && !isGameOver)
        {
            isGameOver = true;
            Target.SetActive(true);
        }

        if (PlayerController.Lives > 0)
        {
            isGameOver = false;
        }
    }
}
