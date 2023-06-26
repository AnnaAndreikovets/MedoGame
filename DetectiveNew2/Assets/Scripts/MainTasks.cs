using UnityEngine;
//Переодется, позавтракать, узнать об произошедшем, осмотреть место преступления, газ для кука, опросить, взять бумагу, найти золото, спа
public class MainTasks : MonoBehaviour { public PlayerInventory playerInventory; public ChooseClothes chooseClothes; public GameObject[] blocks;
    int[] nums = new int[12];
    private void Start() { Checking(); blocks[1].SetActive(false); }
    //вместо текста, который будет нам говорить, что надо взять бумагу пусть говорит что нам надо взять и сделать доску
    public void Checking() { ChangeClothes(); Gas(); Conservations(); Papers(); Gold(); FindOutWhatHappened(); InspectTheCrimeScene(); StartSession(); }
    public void ChangeClothes() { if (chooseClothes.numberClothes == 1 || chooseClothes.numberClothes == 2
            || chooseClothes.numberClothes == 3 || chooseClothes.numberClothes == 4) { blocks[0].SetActive(false); } }
    public void Gas() { for (int i = 0; i < playerInventory.myInventory.Count; i++) {
            if (playerInventory.myInventory[i].itemName == "NeedAGas") { blocks[2].SetActive(true); }
            if (playerInventory.myInventory[i].itemName == "GasKitchen") { blocks[2].SetActive(false); } } }
    public void Conservations() { for (int i = 0; i < playerInventory.myInventory.Count; i++) {
            if (playerInventory.myInventory[i].itemName == "InspectTheCrimeScene") { blocks[3].SetActive(true); }
            if (playerInventory.myInventory[i].itemName == "MuderKetrin") { nums[0] = 1;}
            else if (playerInventory.myInventory[i].itemName == "MurderMaks") { nums[1] = 1; }
            else if (playerInventory.myInventory[i].itemName == "murderWilson") { nums[2] = 1; }
            else if (playerInventory.myInventory[i].itemName == "murderSmit") { nums[3] = 1; }
            else if (playerInventory.myInventory[i].itemName == "murderAdam") { nums[4] = 1; }
            else if (playerInventory.myInventory[i].itemName == "murderAlex") { nums[5] = 1; }
            else if (playerInventory.myInventory[i].itemName == "MuderAlbert") { nums[6] = 1; }
            else if (playerInventory.myInventory[i].itemName == "MurderAnzela") { nums[7] = 1; }
            else if (playerInventory.myInventory[i].itemName == "MurderSofia") { nums[8] = 1; }
            else if (playerInventory.myInventory[i].itemName == "MurderElizabet") { nums[9] = 1; }
            if (nums[0] == 1 && nums[1] == 1 && nums[2] == 1 && nums[3] == 1 && nums[4] == 1 && nums[5] == 1 && nums[6] == 1 && nums[7] == 1 && 
                nums[8] == 1 && nums[9] == 1) { blocks[3].SetActive(false); } } }
    public void Papers() { for (int i = 0; i < playerInventory.myInventory.Count; i++) {
            if (playerInventory.myInventory[i].itemName == "InspectTheCrimeScene") { blocks[4].SetActive(true); }
            if (playerInventory.myInventory[i].itemName == "Board") { blocks[4].SetActive(false); } } }
    public void Gold() { for (int i = 0; i < playerInventory.myInventory.Count; i++) {
            if (playerInventory.myInventory[i].itemName == "ConvA") { blocks[5].SetActive(true); nums[11] = 1; }
            if (playerInventory.myInventory[i].itemName == "gold2" || nums[11] == 1) { blocks[5].SetActive(false); } } } // перед
    public void FindOutWhatHappened() { for (int i = 0; i < playerInventory.myInventory.Count; i++) {
            if (playerInventory.myInventory[i].itemName == "Happened") { blocks[6].SetActive(true); }
            if (playerInventory.myInventory[i].itemName == "FindOutWhatHappened") { blocks[6].SetActive(false); } } }
    public void InspectTheCrimeScene() { for (int i = 0; i < playerInventory.myInventory.Count; i++) {
            if (playerInventory.myInventory[i].itemName == "FindOutWhatHappened") { blocks[7].SetActive(true); }
            if (playerInventory.myInventory[i].itemName == "InspectTheCrimeScene") { blocks[7].SetActive(false); } } }
    public void StartSession() { for (int i = 0; i < playerInventory.myInventory.Count; i++) {
            if (playerInventory.myInventory[i].itemName == "ConvA") { blocks[8].SetActive(true); }
            if (playerInventory.myInventory[i].itemName == "Happened") { blocks[8].SetActive(false); nums[10] = 1; }
            if (nums[10] == 1) { blocks[8].SetActive(false); } } } 
}