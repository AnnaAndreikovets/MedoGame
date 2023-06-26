using UnityEngine;
public class TakePicture : MonoBehaviour { public PlayerInventory pi; public AddThing addThing; public MyPickUp MyPickUp2;  public Animator anim;
    public void Checking() { for (int i = 0; i < pi.myInventory.Count; i++) { if (pi.myInventory[i].itemName == "PoolNet") { if (pi.myInventory2.Count != 5) {
        addThing.TakeAThinhg(); MyPickUp2.TakeAnItem(); } return; } anim.SetTrigger("isTriggered"); } if (pi.myInventory.Count == 0) { 
            anim.SetTrigger("isTriggered"); } }
}