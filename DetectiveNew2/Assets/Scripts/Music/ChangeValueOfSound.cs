using UnityEngine; using UnityEngine.UI;
public class ChangeValueOfSound : MonoBehaviour { public Image imageOfButton; public PlayerInventory myList; public Sprite firstSprite, secondSprite;
    void Start() => CheckingAnActive();
    public void ChangeValueOfMusic() { if (myList.ValueOfSound[0].itemName == "off") { myList.ValueOfSound[0].itemName = "on"; } 
        else { myList.ValueOfSound[0].itemName = "off"; } CheckingAnActive(); }
    public void CheckingAnActive() {  if (myList.ValueOfSound[0].itemName == "off") { AudioListener.pause = true;
            if (imageOfButton)imageOfButton.sprite = secondSprite; } else { AudioListener.pause = false;
            if(imageOfButton)imageOfButton.sprite = firstSprite; } }
}