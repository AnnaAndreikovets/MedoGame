using UnityEngine.SceneManagement; using UnityEngine;
public class CheckFirstDay : MonoBehaviour { public GameObject[] Things; public PlayerInventory pi; public int num1, num2;
    public void Checking() {  // 1 - кабинет // 2 - передняя часть // 3 - коридор большой // 4 - наша комната // 5 - комната максимо
    for (int i = 0; i < pi.myInventory.Count; i++) {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1)) { // 0 - узнали инфу о кнопках 
// 1 - подобрали оружие кнопки // 2 - первое уведомление // 3 - второе уведомление // 4 - открыли коробку // 5 - кнопка закрытия панели с паролем
            if (pi.myInventory[i].itemName == "Gun") { Things[1].SetActive(false); num1 = 1; } 
            if (pi.myInventory[i].itemName == "Letter") { num2 = 1; } 
            if(num1 == 1 && num2 == 1) { Things[2].SetActive(false); Things[3].SetActive(true); }
            if(pi.myInventory[i].itemName == "Information") { Things[0].SetActive(false); } 
            if(pi.myInventory[i].itemName == "OpenCase") { Things[4].SetActive(true); Things[5].SetActive(false); } } 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(2)) { // 0 - рюкзак кнопка  
// 1 - уведомление если не взяли // 2 - кнопка зайти в дом // 3 - рюкзак изображение // 4 - машина // звук машины
            if (pi.myInventory[i].itemName == "Bag") { Things[0].SetActive(false); Things[3].SetActive(false);
                    Things[2].SetActive(true); Things[1].SetActive(false); } 
            if(pi.myInventory[i].itemName == "Car") { Things[4].SetActive(false); Things[5].SetActive(false); } } 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3)) { // 0 - разговор со Смитом 
// 1 - кнопка зайти в нашу комнату  // 2 - уведомление если не взяли ключ // 3 - кнопка зайти к Максу // 4 - Уведомление нельзя к Максу
// 5 - сыграли в лабиринт и выйграли 
            if (pi.myInventory[i].itemName == "FirstSmit") { Things[0].SetActive(false); Things[1].SetActive(true); 
                Things[2].SetActive(false); }
            if (pi.myInventory[i].itemName == "ThingsOnSceneR3") { Things[3].SetActive(true); Things[4].SetActive(false); }
            if (pi.myInventory[i].itemName == "Star2") { Things[5].SetActive(false); } } 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(4)) { // 0 - поставили рюкзак // 1 - ванная с вещами 
// 2 - подобрали звезду // 3 - кнопка поставить // 4 - кнопка открыть рюкзак // 
            if (pi.myInventory[i].itemName == "ThingsOnSceneR3") { Things[0].SetActive(true); Things[1].SetActive(true); 
                Things[3].SetActive(false); }
            if (pi.myInventory[i].itemName == "Star1") { Things[2].SetActive(false); } 
            if (pi.myInventory[i].itemName == "KeyForBag") { Things[0].SetActive(false); Things[4].SetActive(true); } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(5)) { // 0 - разговор с Максимо // 1 - кнопка подобрать доску
// 2 - кнопка для подбора ключа // 3 - типо диалог в котором будет кнопка начать игру. // 4 - изображение, что нужна доска // 5 - изображение взятой доски 
// 6 - тригер для нужна доска
            if (pi.myInventory[i].itemName == "KeyForBag") { if(Things[2] != null)Things[2].SetActive(false); }
            if (pi.myInventory[i].itemName == "Maks") { Things[0].SetActive(false); Things[4].SetActive(true); Things[6].SetActive(true); }
            if (pi.myInventory[i].itemName == "Desk") { Things[3].SetActive(true); if (Things[1] != null)  Things[1].SetActive(false); 
                Things[4].SetActive(false); if (Things[5] != null) Things[5].SetActive(false); Things[6].SetActive(false); } 
            if (pi.myInventory[i].itemName == "SolvedDesk") { Things[3].SetActive(false); } } 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(36)) {  
// 0 - игрок // 1 - враги // 2 - звезда // 3 - ключи // 4 - кнопки // 5 взять звезду // 6  - звершённая панель
            if (pi.myInventory[i].itemName == "SolvedMaze") { Things[0].SetActive(false); Things[1].SetActive(false); 
                Things[2].SetActive(false); Things[3].SetActive(false); Things[4].SetActive(false); Things[6].SetActive(true); } 
            if (pi.myInventory[i].itemName == "Star2") { Things[5].SetActive(false); } } 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(37)) {  // 0 - кнопки
            if (pi.myInventory[i].itemName == "Star3") { Things[0].SetActive(false); } }  } }
    private void Start() => Checking();
}