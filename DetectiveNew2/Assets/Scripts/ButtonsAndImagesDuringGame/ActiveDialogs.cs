using UnityEngine; using UnityEngine.SceneManagement;
public class ActiveDialogs : MonoBehaviour { public GameObject[] dialogs, activeItems; public PlayerInventory pi; 
    public StarsManager inventory; int number, number2, numbre3 = 0; public TakeStar takeStar; public StarsManager starsManager; public AddThing addThing;
    public void CheckOnActiveDialogs() { for (int i = 0; i < pi.myInventory.Count; i++) {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(7)) {
            if (pi.myInventory[i].itemName == "NeedAGas") { dialogs[0].SetActive(false); number = 1; } 
            if(pi.myInventory[i].itemName == "Gas") { number2 = 1; }
            if (pi.myInventory[i].itemName == "murderSmit") { dialogs[3].SetActive(false); }
            if (pi.myInventory[i].itemName == "InspectTheCrimeScene") { dialogs[1].SetActive(true);
                    dialogs[3].SetActive(true); activeItems[4].SetActive(true); }
            if (pi.myInventory[i].itemName == "NeedAGas") { dialogs[2].SetActive(true); }
            if (pi.myInventory[i].itemName == "murderAdam") { dialogs[2].SetActive(false); } 
            if(number == 1 && number2 == 1) { activeItems[1].SetActive(true); } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(8)) {
            if (pi.myInventory[i].itemName == "InspectTheCrimeScene") { dialogs[1].SetActive(true); }
            if (pi.myInventory[i].itemName == "murderWilson") { dialogs[0].SetActive(false); } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(9)) {
            if (pi.myInventory[i].itemName == "Happened") { dialogs[2].SetActive(false); } 
            if (pi.myInventory[i].itemName == "InspectTheCrimeScene") { dialogs[1].SetActive(true); dialogs[2].SetActive(true); }
            if (pi.myInventory[i].itemName == "MuderKetrin") { dialogs[0].SetActive(false); } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(10)) {
            if (pi.myInventory[i].itemName == "Happened") { dialogs[0].SetActive(false); }
            if (pi.myInventory[i].itemName == "InspectTheCrimeScene") { dialogs[1].SetActive(true); dialogs[2].SetActive(true); }
            if (pi.myInventory[i].itemName == "MurderSofia") { activeItems[0].SetActive(false); }
            if (pi.myInventory[i].itemName == "MurderElizabet") { activeItems[1].SetActive(false); } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(11)) {
// 0 - У Ан 1 - канвас с Анжелой 2 - весь алекс 3 - у Алекс 4 - Сегодня чудесный день 5 - награда  6 - инфа первая
            if (pi.myInventory[i].itemName == "Happened") { dialogs[4].SetActive(false); dialogs[1].SetActive(true); }
            if (pi.myInventory[i].itemName == "InspectTheCrimeScene") { dialogs[0].SetActive(true); }
            if (pi.myInventory[i].itemName == "MurderAnzela") { dialogs[0].SetActive(false); dialogs[3].SetActive(true); }
            if (pi.myInventory[i].itemName == "SolvedBreakfast") { dialogs[2].SetActive(true); } 
            if (pi.myInventory[i].itemName == "murderAlex") { dialogs[3].SetActive(false); }
            if (pi.myInventory[i].itemName == "gold") { dialogs[5].SetActive(true); }
            if (pi.myInventory[i].itemName == "gold2") { dialogs[5].SetActive(false); }
            if (pi.myInventory[i].itemName == "ConvA") { dialogs[6].SetActive(false); }
            }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(12)) {
            if (pi.myInventory[i].itemName == "MurderMaks") { dialogs[0].SetActive(false); } } } }
    public void Start() => CheckOnActiveDialogs();
}