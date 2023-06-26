using UnityEngine;
public class Fire : MonoBehaviour { public GameObject Bg1, Bg2, Bg3, minuteHand, minuteHandImage, button; 
    public PlayerInventory playerInventory; private InventoryCase inventory; public MyItem myItem;
    private void Start() {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryCase>();
        for (int i = 0; i < playerInventory.myInventory2.Count; i++)
        { if (playerInventory.myInventory2[i].nameOfItem == "TrashCanWithWater")
            { button.SetActive(true); } } }
    /* Мне надо 1) закрыть кнопку (аниматор)
    2) получить значение TrashCanWithWater
    3) открыть изображение и кнопку для подбора стрелки, поменять задние фоны 
    4) удалить и добавить новый предмет
    5) перезагрузить инвентарь 
    6) условия активности 
    */
    public void Replace() { Bg2.SetActive(true); Bg1.SetActive(false); Bg3.SetActive(false);
        for (int i = 0; i < playerInventory.myInventory2.Count; i++) {
            if (playerInventory.myInventory2[i].nameOfItem == "TrashCanWithWater")
            { for (int p = 0; p < inventory.isFull.Length; p++)
                { if (p == i) { inventory.isFull[p] = false; MyInventorySlot newSlot =
                        inventory.slots[p].GetComponent<MyInventorySlot>(); if (newSlot) { newSlot.Setup(myItem);
                            minuteHand.SetActive(true); minuteHandImage.SetActive(true);
                            playerInventory.myInventory2.RemoveAt(i); } }}}}}
}