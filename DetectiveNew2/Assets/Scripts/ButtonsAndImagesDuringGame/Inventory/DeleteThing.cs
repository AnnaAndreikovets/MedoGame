using UnityEngine;
public class DeleteThing : MonoBehaviour { public PlayerInventory playerInventory; public string nameItem;
    public void DeleteThing_() { for (int i = 0; i < playerInventory.myInventory.Count; i++) {
        if (playerInventory.myInventory[i].itemName == nameItem) { playerInventory.myInventory.RemoveAt(i); }}}
}