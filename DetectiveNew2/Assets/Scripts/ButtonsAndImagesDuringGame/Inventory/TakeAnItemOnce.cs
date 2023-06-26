using UnityEngine;
public class TakeAnItemOnce : MonoBehaviour { public PlayerInventory pi; public AddThing addThing; public string nameOfItem;
    public void CheckIfTook1() { for (int i = 0; i < pi.myInventory.Count; i++) {
            if (pi.myInventory[i].itemName == nameOfItem) { return; } addThing.TakeAThinhg(); } }
    public void CheckIfTook2() { for (int i = 0; i < pi.myInventory.Count; i++) { 
            if (pi.myInventory[i].itemName == nameOfItem) { return; } } addThing.TakeAThinhg2(); }
}