using UnityEngine;
public class TakeGas : MonoBehaviour {public PlayerInventory pi; public AddThing addThing; public MyPickUp myPickUp; public Gas gas; 
    public ActiveDialogs activeDialogs;
    public void TakeItem() { if (pi.myInventory2.Count <= 4) { myPickUp.TakeAnItem(); addThing.TakeAThinhg(); gas.GasOn(); activeDialogs.CheckOnActiveDialogs();}}
}