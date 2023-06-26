using UnityEngine;
public class DeleteItem : MonoBehaviour { public PlayerInventory playerInventory; 
    public InventoryCase inventory; public MyItem myItem1; public string nameItem;
    private void Start() { inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryCase>(); }
    public void DeleteItem_() { for (int i = 0; i < playerInventory.myInventory2.Count; i++) {
        if (playerInventory.myInventory2[i].nameOfItem == nameItem) { 
            for (int p = 0; p < inventory.isFull.Length; p++){ if (p == i)
                { inventory.isFull[p] = false; MyInventorySlot newSlot =
                    inventory.slots[p].GetComponent<MyInventorySlot>(); if (newSlot) {
                        newSlot.Setup(myItem1); playerInventory.myInventory2.RemoveAt(i); }}}}}}
}