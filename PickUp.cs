using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    private GameObject invObj;
    private inventoryScript invRef;

    // Start is called before the first frame update
    void Start()
    {
        invObj = GameObject.Find("GameManager");
        invRef = invObj.GetComponent<inventoryScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "pickupable")
        {
            invRef.pickupItem(other.gameObject);
        }
    }
}
