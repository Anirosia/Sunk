using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    private Inventory inventory;
    private GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        inventory = player.GetComponent<Inventory>();
        Debug.Log(inventory);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i <= inventory.slots.Length; i++) //loops through the inventory checking everything.
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    inventory.slots[i] = this.gameObject;
                    this.gameObject.SetActive(false);
                    // or you can use destory if its a coin or something else 
                    //Destroy(this.gameObject);

                    break;
                }
            }
        }
    }
}
