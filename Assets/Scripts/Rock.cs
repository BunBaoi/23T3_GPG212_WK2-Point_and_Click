using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Rock : MonoBehaviour
{
    [Header("Health")]
    public int counter = 0;
    public int health = 10;

    bool alive = true;

    [Header("Gameobject Update")]
    public TMP_Text HealthText;
    public GameObject block;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HealthText.text = "Health: " +  health.ToString();
    }

    public void OnMouseDown()
    {
        //counter += 1;
        //Debug.Log("Count: " + counter);
        health -= 1;
        Debug.Log("Health: " + health + " ");
        
        //Debug.Log(alive);
        
        if (health <= 0)
        {
            alive = false;
            Destroy(gameObject);

            Debug.Log(alive);
        }
    }
}
