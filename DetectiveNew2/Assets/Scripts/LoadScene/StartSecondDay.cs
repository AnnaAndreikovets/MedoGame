using UnityEngine;
public class StartSecondDay : MonoBehaviour { public Animator animPlayer; public PlayerInventory playerInventory;
    //private InventoryCase inventory; public Animator dontWakeUp;
    public ChooseClothes chooseClothes; public GameObject arrow1, arrow2, notification;
    public void CheckRightClothes() {arrow1.SetActive(false); notification.SetActive(false); arrow2.SetActive(true); }
    private void Start() { animPlayer.SetTrigger("change5"); chooseClothes.numberClothes = 5; chooseClothes.SaveCl();
    //inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryCase>();
    }
    //public void DontWakeUp() { dontWakeUp.SetTrigger("IsTriggered"); }
}