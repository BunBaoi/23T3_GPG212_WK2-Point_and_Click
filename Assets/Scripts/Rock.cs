using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Rock : MonoBehaviour
{
    [Header("UI")]
    public float health;
    public float scoreboard;
    public float playerscore;
    public float balance;

    public GameEvent GameEvent;

    public TextMeshProUGUI HealthText;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI BalanceText;

    public float radnum;
    private SpriteRenderer rend;

    public GameObject Pickaxe;
    public GameObject Lava;
    public GameObject Water;



    // Start is called before the first frame update
    void Start()
    {
        HealthText.text = "Health: " + health.ToString();
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject water = GameObject.FindWithTag("LavaBucket");
        BalanceText.text = "Balance: $" + balance.ToString();
    }

    private void OnMouseDown()
    {
        

        if(gameObject.tag == "Stone")
        {
            health = health - GameEvent.damage;
            Debug.Log("Counter: " + health);
            HealthText.text = "Health: " + health.ToString();
        }
        else if (gameObject.tag == "Lava")
        {
            health = health - GameEvent.damage;
            Debug.Log("Counter: " + health);
            HealthText.text = "Health: " + health.ToString();

        }
        else if (gameObject.tag == "Water")
        {
            health = health - GameEvent.damage;
            Debug.Log("Counter: " + health);
            HealthText.text = "Health: " + health.ToString();
        }



        if (health <= 0)
        {
            radnum = Random.Range(1, 100);
            if(radnum <= 79)
            {
                gameObject.tag = "Stone";
                rend.color = Color.grey;
                Debug.Log(radnum + " " + gameObject.tag);
            }
            else if(radnum is >= 80 and < 90)
            {
                gameObject.tag = "Lava";
                rend.color = Color.red;
                Debug.Log(radnum + " " + gameObject.tag);
            }
            else
            {
                gameObject.tag = "Water";
                rend.color = Color.blue;
                Debug.Log(radnum + " " + gameObject.tag);
            }
            
            health = 10;
            balance += 2;
            playerscore += 1;
            

            HealthText.text = "Health: " + health.ToString();
            BalanceText.text = "Balance: $" + balance.ToString();
            ScoreText.text = "Current Score: " + playerscore.ToString();

            Debug.Log("RESPAWN");
        }

    }
}
