using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject[] slots; //the number of items you can hold
    public bool[] isFull; // checks if the slot is in use...or is Full (._. ')
    void Start()
    {
        System.Array.Resize(ref isFull,slots.Length); // this resizes the the isFull array to always equal the amount of slots you have.
    }

}
