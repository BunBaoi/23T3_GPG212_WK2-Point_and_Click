using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameEvent : MonoBehaviour
{


    public Rock RockStatus;
    public int count;
    public GameObject PrefabSpwan;
    public int counter;

    [Header("UI")]
    public TextMeshProUGUI HealthText;
    public TMP_Text Score;
    public TMP_Text PlayerScore;



    // Start is called before the first frame update
    void Start()
    {
        Instantiate(PrefabSpwan, new Vector3(0,0,0), Quaternion.identity);

        RockStatus = GameObject.Find("Rocks").GetComponent<Rock>();

        //count = RockStatus.health;


        Debug.Log(count);
    }

    // Update is called once per frame
    void Update()
    {
        count = RockStatus.health;
        HealthUI();

        //Debug.Log("Counter " + counter);
        //counter = counter += 1;




        if (RockStatus.alive == false)
        {
            Debug.Log("This call works");
            RockStatus.alive = true;
        }
        else
        {

        }
    }

    void HealthUI()
    {
        HealthText.text = $"Health: {count}";
       
    }
}
