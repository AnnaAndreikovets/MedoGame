using UnityEngine;
public class TakeImageOfBG : MonoBehaviour { public PlayerInventory pi; public AddThing addThing; public MyPickUp myPickUp;
    public void TakeItem() { if (pi.myInventory2.Count <= 4) { myPickUp.TakeAnItem(); addThing.TakeAThinhg(); } }
}
