using UnityEngine;
public class ClosetDL : MonoBehaviour {public PlayerInventory playerInventory;
    private InventoryCase inventory; public MyItem myItem; public GameObject Dark, Dark_, Light, notification, button;
    private void Start() { inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryCase>();
        for (int i = 0; i < playerInventory.myInventory2.Count; i++)
        { if (playerInventory.myInventory2[i].nameOfItem == "LightBubl") { notification.SetActive(true); } } }    
    public void LightOn() {
        for (int i = 0; i < playerInventory.myInventory2.Count; i++) {
            if (playerInventory.myInventory2[i].nameOfItem == "LightBubl") {
                playerInventory.myInventory2.RemoveAt(i); for (int p = 0; p < inventory.isFull.Length; p++) {
                    if (p == i) { inventory.isFull[p] = false;
                        MyInventorySlot newSlot = inventory.slots[p].GetComponent<MyInventorySlot>(); if (newSlot) {
                            newSlot.Setup(myItem); Dark.SetActive(false); Dark_.SetActive(false); 
                            Light.SetActive(true); notification.SetActive(false); } } } } } }
}