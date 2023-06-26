using UnityEngine;
public class Gas : MonoBehaviour { public GameObject button1, button2, candle, candleImage, hourHand, dialogBox;
    public PlayerInventory playerInventory; public InventoryCase inventory; public MyItem myItem1;
    private void Start() { inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryCase>();
        GasOn(); CandleOn(); for (int i = 0; i < playerInventory.myInventory.Count; i++) {
            if (playerInventory.myInventory[i].itemName == "CandleOnTheScene")
            { candle.SetActive(true); candleImage.SetActive(true); button1.SetActive(false); }
            else if (playerInventory.myInventory[i].itemName == "HH2") { hourHand.SetActive(false); }
            else if (playerInventory.myInventory[i].itemName == "GasKitchen") { dialogBox.SetActive(false); } } }
    public void ReplaceCandle() { for (int i = 0; i < playerInventory.myInventory2.Count; i++)
        { if (playerInventory.myInventory2[i].nameOfItem == "Candle"){ for (int p = 0; p < inventory.isFull.Length; p++)
                { if (p == i) { inventory.isFull[p] = false; MyInventorySlot newSlot =
                inventory.slots[p].GetComponent<MyInventorySlot>(); if (newSlot) { button1.SetActive(false);
                            newSlot.Setup(myItem1); playerInventory.myInventory2.RemoveAt(i); } } } } } }
    public void DeleteGas() { for (int i = 0; i < playerInventory.myInventory2.Count; i++) {
            if (playerInventory.myInventory2[i].nameOfItem == "Gas") {for (int p = 0; p < inventory.isFull.Length; p++)
                { if (p == i) { inventory.isFull[p] = false; MyInventorySlot newSlot =
            inventory.slots[p].GetComponent<MyInventorySlot>(); if (newSlot) { button2.SetActive(false);
                            newSlot.Setup(myItem1); playerInventory.myInventory2.RemoveAt(i); } } } } } }
    public void GasOn() { for (int i = 0; i < playerInventory.myInventory2.Count; i++) {  if (playerInventory.myInventory2[i].nameOfItem == "Gas") {
        for (int o = 0; o < playerInventory.myInventory.Count; o++) { if (playerInventory.myInventory[o].itemName == "NeedAGas") {
            button2.SetActive(true); } } } } }
    public void CandleOn() { for (int i = 0; i < playerInventory.myInventory2.Count; i++) {
            for (int p = 0; p < playerInventory.myInventory.Count; p++) {
                if (playerInventory.myInventory2[i].nameOfItem == "Candle"
                    && playerInventory.myInventory[p].itemName == "GasKitchen") {
                    button1.SetActive(true);} } } }
    public void DialogBoxOff() { dialogBox.SetActive(false);}
    public void Candle() { candle.SetActive(true); candleImage.SetActive(true); }
}