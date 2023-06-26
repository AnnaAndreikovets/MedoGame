using UnityEngine; using UnityEngine.SceneManagement; // 0- письмо 1 - багаж 2 - ключ(дверь) 3 - оставить вещи 4 -разговор док 5 - игральная доска
// 6 - головаломка 7 - осмотерться 8 - осмотреть кабинет(только на первой сцене)
public class MainTasks1 : MonoBehaviour { public PlayerInventory pi; public GameObject[] blocks; int num1, num2, num3, num4;
    private void Start() {Checking(); } 
    public void Checking() { for (int i = 0; i < pi.myInventory.Count; i++) {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1)){ // письмо и осмотрется вкл умолчание
            if (pi.myInventory[i].itemName == "Letter") { blocks[0].SetActive(false); }
            if (pi.myInventory[i].itemName == "Gun") { blocks[7].SetActive(false); } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(2)){ // сумка вкл умолчание
            if (pi.myInventory[i].itemName == "Bag") { blocks[1].SetActive(false);}}
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3)) { 
// ключ, вещи, макс, осмотреться вкл умолчание // игральная доска, головоломка после разговора
            if (pi.myInventory[i].itemName == "FirstSmit") {  blocks[2].SetActive(false);} 
            if (pi.myInventory[i].itemName == "ThingsOnSceneR3") { blocks[3].SetActive(false); } Ch2(i);}
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(4)){ 
                //вещи, макс вкл умолчание, осмотреться // игральная доска, головоломка после разговора
            if (pi.myInventory[i].itemName == "ThingsOnSceneR3") { blocks[3].SetActive(false); } Ch2(i); }
        //макс, осмотреться вкл умолчание // игральная доска, головоломка после разговора
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(5)){ Debug.Log("Called"); Ch2(i); } } }
    void Ch2(int i) { if (pi.myInventory[i].itemName == "Maks") { blocks[4].SetActive(false); blocks[6].SetActive(true);
            if (num4 !=1) blocks[5].SetActive(true); }
        if (pi.myInventory[i].itemName == "Desk") { blocks[5].SetActive(false); num4 = 1; }
        if (pi.myInventory[i].itemName == "SolvedDesk") { blocks[6].SetActive(false); }
        if (pi.myInventory[i].itemName == "Star1") { num1 = 1; }
        if (pi.myInventory[i].itemName == "Star2") { num2 = 1; }
        if (pi.myInventory[i].itemName == "Star3") { num3 = 1; }
        if (num1 == 1 && num2 == 1 && num3 == 1) { blocks[7].SetActive(false); } }
}