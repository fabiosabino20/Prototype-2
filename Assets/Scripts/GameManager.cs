using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int playerHealth = 3;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(string.Format("Starting the game!\nPlayer health: {0}\nScore: {1}", playerHealth, score));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealth(int damage)
    {
        playerHealth -= damage;
        Debug.Log(string.Format("You got hit! Player health: {0}", playerHealth));

        if (playerHealth == 0)
        {
            Debug.Log("Game Over!");
        }
    }

    public void UpdateScore(int addScore)
    {
        score += addScore;
        Debug.Log(string.Format("Score: {0}", score));
    }
}
