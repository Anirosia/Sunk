using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryScript : MonoBehaviour
{
    

    ArrayList invItems = new ArrayList();

    public ArrayList invSlots = new ArrayList();

    public GameObject pauseMenu;

    private bool isFull;
    bool showInventory;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (!showInventory)
            {
                showInventory = true;
            }
            else
            {
                showInventory = false;
            }
        }

        InventoryHandler();

    }

    void InventoryHandler()
    {
        if (showInventory)
        {
            populateInventory();
            pauseMenu.SetActive(true);
            
        }
        else
        {
            
            pauseMenu.SetActive(false);
        }
    }

    void populateInventory()
    {
        for (int i = 0; i < invItems.Count; i++)
        {
            invSlots.Add(invItems[i]);
        }
    }

    public void pickupItem(GameObject item)
    {
        if (!isFull)
        {
            invItems.Add(item);

        }
        else
        {
            // inv full
        }

    }

}
