using UnityEngine;
public class MyPickUp2 : MonoBehaviour{ [SerializeField] private MyItem thisItem;
    private InventoryCase inventory; public PlayerInventory playerInventory;
    private void Start() { if (inventory) { inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryCase>(); } }
    public void TakeAnItem() { if (playerInventory) { for (int p = 0; p < inventory.slots.Length; p++)
            { if (inventory.isFull[p] == false) {
                    inventory.playerInventory.myInventory2.Add(thisItem);
                    inventory.isFull[p] = true; MyInventorySlot newSlot =
                        inventory.slots[p].GetComponent<MyInventorySlot>();
                    if (newSlot) { newSlot.Setup(thisItem); break; } } } } }
    public void TakeNothing() { if (playerInventory) { for (int p = 0; p < inventory.slots.Length; p++) {
                if (inventory.isFull[p] == false) {
                    MyInventorySlot newSlot = inventory.slots[p].GetComponent<MyInventorySlot>();
                    if (newSlot) { newSlot.Setup(thisItem); break; } } } } }
    private void OnTriggerEnter2D(Collider2D other) { if (playerInventory) {
            for (int p = 0; p < inventory.slots.Length; p++) { if (inventory.isFull[p] == false) {
                    inventory.playerInventory.myInventory2.Add(thisItem);
                    inventory.isFull[p] = true; MyInventorySlot newSlot =
                        inventory.slots[p].GetComponent<MyInventorySlot>();
                    if (newSlot) { newSlot.Setup(thisItem); break; } } } } }
}