using UnityEngine;
public class MyPickUp1 : MonoBehaviour {[SerializeField] private MyItem thisItem; public GameObject[] Things; 
    private InventoryCase inventory; public GameObject ImageOfThing; public PlayerInventory playerInventory;
    private void Start() { inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryCase>(); }
    public void TakeAnItem() { if (playerInventory) { for (int p = 0; p < inventory.slots.Length; p++) {
                 if (inventory.isFull[p] == false) { inventory.playerInventory.myInventory2.Add(thisItem);
                    inventory.isFull[p] = true; MyInventorySlot newSlot = 
                        inventory.slots[p].GetComponent<MyInventorySlot>();
        if (newSlot) { newSlot.Setup(thisItem); for (int l = 0; l < Things.Length; l++)
                        { Destroy(Things[l]); }
                        break; } } } } } 
    private void OnTriggerEnter2D(Collider2D other) { if (playerInventory) {
            for (int p = 0; p < inventory.slots.Length; p++) { if (inventory.isFull[p] == false) {
                    inventory.playerInventory.myInventory2.Add(thisItem);
                    inventory.isFull[p] = true; MyInventorySlot newSlot =
                        inventory.slots[p].GetComponent<MyInventorySlot>();
                    if (newSlot)
                    { newSlot.Setup(thisItem); for (int l = 0; l < Things.Length; l++)
                        { Destroy(Things[l]); } break; } } } } }
}