using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//InvSy2
public class ItemPickup : MonoBehaviour
{

    public Item Item;

    void Pickup()
    {
        InventoryManager.Instance.Add(Item);
        Destroy(gameObject);
    }

    /* public void Update()
      {
          if (Input.GetKeyDown(KeyCode.Mouse0))
          {
              Pickup();
          }*/


    private void OnMouseDown()
    {
        Pickup();
    }
}


    
   

