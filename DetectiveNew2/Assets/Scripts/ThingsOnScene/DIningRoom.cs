using UnityEngine;
public class DIningRoom : MonoBehaviour { public PlayerInventory playerInventory;
    public GameObject drBG2, drBG1; public Animator anim, animVC; int num1, num2, num3;
    public VectorValue pos, pos1; public PlayerController1 playerController1;
    public GameObject[] MH; public ChooseClothes chooseClothes; 
    public void SitDown() {  for (int k = 0; k < MH.Length; k++) {
            if (chooseClothes.numberClothes == 1) { MH[0].SetActive(true); }
            else if (chooseClothes.numberClothes == 2) { MH[1].SetActive(true); }
            else if (chooseClothes.numberClothes == 3) { MH[2].SetActive(true); }
            else if (chooseClothes.numberClothes == 4) { MH[3].SetActive(true); }
            else { Debug.Log("Index of animation is uncorrected"); } }
        drBG2.SetActive(true); drBG1.SetActive(false);
        playerController1.ChangePosition(pos); }
    public void StandUp() { playerController1.ChangePosition(pos1); for (int i = 0; i < MH.Length; i++) {
            MH[i].SetActive(false); } }
    public void ChangeBG2() { drBG2.SetActive(false); drBG1.SetActive(true); }
    public void StartConversationWithAdam() { for (int i = 0; i < playerInventory.myInventory.Count; i++) {
        if (num1 >= 1 && num2 >=1 && num3 >=1) { anim.SetTrigger("isTriggered"); animVC.SetTrigger("isTriggered"); }
            if (playerInventory.myInventory[i].itemName == "ConvWAD") { num1++; }
            if ( playerInventory.myInventory[i].itemName == "ConvM") { num2++; }
            if (playerInventory.myInventory[i].itemName == "ConvM") { num3++; } } }
    public void SolveConversationWithAdam() { for (int i = 0; i < playerInventory.myInventory.Count; i++)
        { if (playerInventory.myInventory[i].itemName == "Adam") { anim.SetTrigger("isTriggered"); } } }
}