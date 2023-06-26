using UnityEngine;
public class TakeMinuteHand : MonoBehaviour {public PlayerInventory pi; public AddThing addThing; public MyPickUp1 myPickUp; public Open1 open1;
    public void TakeItem() { if (pi.myInventory2.Count <= 4) { myPickUp.TakeAnItem(); addThing.TakeAThinhg();  open1.Open(); } }
}