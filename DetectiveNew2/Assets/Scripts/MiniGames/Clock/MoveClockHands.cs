using UnityEngine; // HourHand: -77.5, MinuteHand: 150    // изначально 6 и 0.5 вместо 30 и 2.5
public class MoveClockHands : MonoBehaviour {[SerializeField] private GameObject minuteHand, hourHand;
    private float zHour, num1, num2, num3; public GameObject door, buttonOpen, buttonAdd, arrow1, arrow2, clockBG; 
    public PlayerInventory playerInventory; public Animator anim;
    public void RotateClockHandRight() { minuteHand.transform.Rotate(0f, 0f, -30f);
        hourHand.transform.Rotate(0f, 0f, -2.5f); zHour = zHour - 2.5f; }
    public void RotateClockHandLeft() { minuteHand.transform.Rotate(0f, 0f, 30f);
        hourHand.transform.Rotate(0f, 0f, 2.5f); zHour = zHour + 2.5f; }
    public void CheckRightResult() { if (zHour == -77.5f) { door.SetActive(false); buttonOpen.SetActive(false);
            anim.SetTrigger("isTriggered"); } }
    private void Update() { for (int i = 0; i < playerInventory.myInventory.Count; i++)
        { if (num1 >=1 && num2 >=1 && num3 >= 1){
            arrow1.SetActive(true); arrow2.SetActive(true); buttonAdd.SetActive(false); }
        if (playerInventory.myInventory[i].itemName == "CheckBG") { clockBG.SetActive(true); num1++; }
            else if (playerInventory.myInventory[i].itemName == "CheckMH") { minuteHand.SetActive(true); num2++; }
                else if (playerInventory.myInventory[i].itemName == "CheckHH") { hourHand.SetActive(true); num3++; }}}
} 