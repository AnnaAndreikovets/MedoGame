using UnityEngine; using UnityEngine.SceneManagement;
public class CheckMurder : MonoBehaviour { public GameObject[] unactive, Things; public PlayerInventory pi;
    public GameObject Thing_1, Thing_2, Thing_3, Thing_4, Thing_5, Thing_6, Thing_7, Thing_8, Thing_9,
        star, light_, button, door, kitchenBG, gold; public AudioSource audioSource;
    public void SetActive() { for (int p = 0; p < pi.myInventory.Count; p++) {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(7)) {if (pi.myInventory[p].itemName == "LightBubl1") { 
            Thing_1.SetActive(false); Thing_2.SetActive(false); Thing_3.SetActive(false); Thing_4.SetActive(true); } 
        else if (pi.myInventory[p].itemName == "Happened") { Thing_8.SetActive(true); kitchenBG.SetActive(true); Things[2].SetActive(true); }
        else if(pi.myInventory[p].itemName == "InspectTheCrimeScene") { Thing_8.SetActive(false); Things[1].SetActive(true);
            Things[2].SetActive(false); }
        else if (pi.myInventory[p].itemName == "Star1") { star.SetActive(false); light_.SetActive(false); door.SetActive(false); 
            button.SetActive(false);}
        if (pi.myInventory[p].itemName == "gold") { gold.SetActive(false); }
        if (pi.myInventory[p].itemName == "CheckBG") { Things[0].SetActive(true); } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(9)) { if (pi.myInventory[p].itemName == "InspectTheCrimeScene") { 
            Thing_1.SetActive(true); } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(10))
            { if (pi.myInventory[p].itemName == "Candle") { Thing_1.SetActive(false); }
                else if (pi.myInventory[p].itemName == "Happened") { Thing_2.SetActive(false); }} 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(11)) { if (pi.myInventory[p].itemName == "TrashCanWithWater") {
            Thing_4.SetActive(true); Thing_7.SetActive(true); } if (pi.myInventory[p].itemName == "minuteHand") { Thing_4.SetActive(false);
                Thing_7.SetActive(false); Thing_1.SetActive(false); Things[3].SetActive(true); Things[1].SetActive(false); Things[2].SetActive(false); }
            for (int i = 0; i < pi.myInventory2.Count; i++) { if (pi.myInventory2[i].nameOfItem == "TrashCanWithWater") { 
            Thing_1.SetActive(true);} }}
        if ( SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(13)) {  if (pi.myInventory[p].itemName == "Board") { 
            Thing_2.SetActive(false); Thing_3.SetActive(true); Thing_1.SetActive(true);} } } } 
    public void SetUnactive()
    {for (int p = 0; p < pi.myInventory.Count; p++) { 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(9))
            { if (pi.myInventory[p].itemName == "Papers") { Thing_1.SetActive(false);
                    Thing_3.SetActive(false); Thing_4.SetActive(true); }
            else if (pi.myInventory[p].itemName == "bgPath1") { Thing_2.SetActive(false); } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(11))
            { if (pi.myInventory[p].itemName == "TrashCanWithWater")
            { Thing_1.SetActive(false); Thing_2.SetActive(true); Thing_3.SetActive(false); Thing_5.SetActive(false); audioSource.Pause(); }
            else if (pi.myInventory[p].itemName == "minuteHand") { Thing_4.SetActive(false);
                    Thing_7.SetActive(false); }
            else if (pi.myInventory[p].itemName == "LightBubl") { Thing_6.SetActive(false); Things[0].SetActive(false); } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(7)) {if (pi.myInventory[p].itemName == "NeedAGas") { Things[3].SetActive(true); } 
            else if (pi.myInventory[p].itemName == "Gas" && Thing_5 != null) { Thing_5.SetActive(false); Things[3].SetActive(false); } 
                else if (pi.myInventory[p].itemName == "TrashCan") { Thing_6.SetActive(false); Thing_7.SetActive(false);}}}}
    private void Start() { SetActive(); SetUnactive(); }
}