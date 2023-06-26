using UnityEngine;
public class CheckHH : MonoBehaviour { public GameObject hourHand; public InventoryItem InventoryItem;
    public MyItem myItem; public PlayerInventory playerInventory; private InventoryCase inventory;
    private void Start() { inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryCase>(); }
    public void Check() {for (int i = 0; i < playerInventory.myInventory2.Count; i++) {
            if (playerInventory.myInventory2[i].nameOfItem == "hourHand") { hourHand.SetActive(true);
                for (int p = 0; p < inventory.isFull.Length; p++) {
                    if (p == i)
                    {
                        inventory.isFull[p] = false; MyInventorySlot newSlot =
                          inventory.slots[p].GetComponent<MyInventorySlot>(); if (newSlot)
                    { newSlot.Setup(myItem); playerInventory.myInventory2.RemoveAt(i);
                        playerInventory.myInventory.Add(InventoryItem); } } } } } }
}