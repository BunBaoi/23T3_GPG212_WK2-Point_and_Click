using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Rock : MonoBehaviour
{
    [Header("Health")]
    public int health;

    public bool alive = true;


    [Header("Gameobject Update")]
    public GameObject block;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HealthText.text = $"Health: {health}";
        // Left Click Button
        if (Input.GetMouseButtonDown(0))
        {
            health -= 1;
            Debug.Log("Left Click works");
            Debug.Log("Health: " + health + " ");


            //Game condition
            if (health <= 0)
            {
                alive = false;
                Destroy(gameObject);

                Debug.Log("Rock is destroyed");
            }
            Debug.Log("Status: " + alive);
        }

        // Right Click Button
        if (Input.GetMouseButtonDown(1))
        {
            health += 1;
            Debug.Log("HEALING " + health);
        }
    }
}
