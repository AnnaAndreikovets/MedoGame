using UnityEngine;
public class MyPickUp : MonoBehaviour {[SerializeField] private MyItem thisItem; public GameObject Thing;
    private InventoryCase inventory; public GameObject ImageOfThing; public PlayerInventory playerInventory;
    private void Start() { inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryCase>(); }
    public void TakeAnItem() { if (playerInventory && inventory.isFull[4] == false) { for (int p = 0; p < inventory.slots.Length; p++)
        { if (inventory.isFull[p] == false) { inventory.playerInventory.myInventory2.Add(thisItem); inventory.isFull[p] = true;
            MyInventorySlot newSlot = inventory.slots[p].GetComponent<MyInventorySlot>(); if (newSlot) { newSlot.Setup(thisItem); Destroy(Thing); break; }}}}}
}