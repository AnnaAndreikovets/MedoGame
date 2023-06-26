using UnityEngine;
public class TakeTrashcan : MonoBehaviour {public PlayerInventory pi; public AddThing addThing; public MyPickUp1 myPickUp; public Water water;
    public void TakeItem() { if (pi.myInventory2.Count <= 4) { myPickUp.TakeAnItem(); addThing.TakeAThinhg(); water.TrashCan(); } }
}