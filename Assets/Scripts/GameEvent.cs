using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameEvent : MonoBehaviour
{

    public float damage = 1;
    public float balance;

    public GameObject[] itemsToEquip; // Drag and drop the items you want to equip here in the Inspector.

    private GameObject equippedItem;
    private Button currentButton;

    public Rock rock;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SPAWNED");
        equippedItem = itemsToEquip[0];
        Debug.Log(equippedItem);
    }


    public void EquipItem(Button button)
    {
        if (currentButton != null)
        {
            // If there's a currently equipped item and a new button is clicked,
            // unequip the current item and deactivate it.
            UnequipItem();

        }

        // Find the index of the clicked button.
        int itemIndex = System.Array.IndexOf(itemsToEquip, button.gameObject);
        Debug.Log(equippedItem);

        // Check if the item index is valid.
        if (itemIndex >= 0 && itemIndex < itemsToEquip.Length)
        {
            equippedItem = itemsToEquip[itemIndex];
            equippedItem.SetActive(true);
            currentButton = button;
        }
    }

    public void UnequipItem()
    {
        if (equippedItem != null)
        {
            equippedItem.SetActive(false);
            equippedItem = null;
            // Reset the currentButton reference to null.
            currentButton = null;
        }
    }
    public void PickUpgrade()
    {
        if (rock.balance >= 2)
        {
            rock.balance = rock.balance - 2;
            Debug.Log("New Balance" + rock.balance);
            damage++;
            Debug.Log("Damage " + damage);

        }

    }
}
