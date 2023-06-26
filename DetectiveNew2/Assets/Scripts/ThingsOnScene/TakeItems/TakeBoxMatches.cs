using UnityEngine;
public class TakeBoxMatches : MonoBehaviour {public PlayerInventory pi; public Open1 open1; public Animator anim;
    public void TakeItem() { if (pi.myInventory2.Count <= 4) { open1.Open(); } else{ anim.SetTrigger("isTriggered"); } }
}