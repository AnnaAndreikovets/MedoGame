using UnityEngine;
public class RotatePathOfPicture : MonoBehaviour { public PlayerInventory playerInventory; public GameObject pathOnScene;
    public void RotateObject() { for (int i = 0; i < playerInventory.myInventory.Count; i++) {
            if (playerInventory.myInventory[i].itemName == "SolvedPicture") { }
            else { Rotate2(); } } }
    public void Rotate2() { this.gameObject.transform.Rotate(0f, 0f, 90.000f) ; pathOnScene.transform.Rotate(0f, 0f, 90.000f); }
}