using UnityEngine;
public class ChangeLightFireplalce : MonoBehaviour { public Animator anim; public PlayerInventory pi; public string nameOfItem;
    private void Start() { for (int i = 0; i < pi.myInventory.Count; i++) {
            if (pi.myInventory[i].itemName == nameOfItem) { anim.SetTrigger("isTriggered"); } } }
}