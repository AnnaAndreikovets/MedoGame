using UnityEngine;
public class Water : MonoBehaviour { public GameObject button;
    public PlayerInventory playerInventory; public InventoryCase inventory; public MyItem myItem;
    private void Start() { inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryCase>();
        for (int i = 0; i < playerInventory.myInventory2.Count; i++) {
            if (playerInventory.myInventory2[i].nameOfItem == "TrashCan") { button.SetActive(true); } } }
    public void Replace() {
        for (int i = 0; i < playerInventory.myInventory2.Count; i++)
        { if (playerInventory.myInventory2[i].nameOfItem == "TrashCan") {
            for (int p = 0; p < inventory.isFull.Length; p++) { if (p == i) {
                        inventory.isFull[p] = false; MyInventorySlot newSlot =
                inventory.slots[p].GetComponent<MyInventorySlot>(); if (newSlot) { button.SetActive(false);
                            newSlot.Setup(myItem); playerInventory.myInventory2.RemoveAt(i); } } } } } }
    public void TrashCan() { button.SetActive(true); }
}