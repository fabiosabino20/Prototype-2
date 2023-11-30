using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class AnimalManager : MonoBehaviour
{
    public Slider hungerSlider;
    public int amountToBeFed = 3; // Health
    private int currentFedAmount = 0;
    private int addScore = 1;
    private GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        hungerSlider.maxValue = amountToBeFed;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHunger(int food)
    {
        currentFedAmount += food;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = currentFedAmount;

        if (currentFedAmount >= amountToBeFed)
        {
            gameManager.UpdateScore(addScore);
            Destroy(gameObject);
        }
    }
}
