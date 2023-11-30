using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class DetectFoodCollision : MonoBehaviour
{
    private int foodStrenght = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dog"))
        {
            other.GetComponent<AnimalManager>().UpdateHunger(foodStrenght);
            Destroy(gameObject);
        }
    }
}
