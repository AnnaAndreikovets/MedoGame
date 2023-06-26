using UnityEngine;
public class Papers : MonoBehaviour { public GameObject Paper1, Paper2, button, boardImage, boardButton; 
    public InventoryCase inventory; public MyItem myItem; public PlayerInventory playerInventory;
    private void Start() { inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryCase>();
        for (int i = 0; i < playerInventory.myInventory.Count; i++) {
            if (playerInventory.myInventory[i].itemName == "InspectTheCrimeScene") {
                for (int p = 0; p < playerInventory.myInventory2.Count; p++) {
                    if (playerInventory.myInventory2[p].nameOfItem == "Papers") { button.SetActive(true); } } } } }
    public void Replace() { Paper1.SetActive(false); Paper2.SetActive(true); }
    public void CreateInvestigionBoard() { for (int p = 0; p < playerInventory.myInventory2.Count; p++) { 
        if (playerInventory.myInventory2[p].nameOfItem == "Papers") { for (int k = 0; k < inventory.isFull.Length; k++){
            if (k == p) { inventory.isFull[k] = false; MyInventorySlot newSlot =
                inventory.slots[p].GetComponent<MyInventorySlot>();  if (newSlot) {
                    button.SetActive(false); boardImage.SetActive(true); newSlot.Setup(myItem);
                            boardButton.SetActive(true); playerInventory.myInventory2.RemoveAt(p); }}}}}}
}