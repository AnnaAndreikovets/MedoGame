using UnityEngine; using UnityEngine.SceneManagement;
public class StartFourthDay : MonoBehaviour { public GameObject arrowForExit, arrow, triggerForNotification; 
    public ChooseClothes chooseClothes; public PlayerInventory pi;
    public void CheckingClothes() { if ( chooseClothes.numberClothes != 5) {
            arrowForExit.SetActive(true); arrow.SetActive(false); triggerForNotification.SetActive(false); } }
    public void ChangeC() {
        for (int i = 0; i < pi.myInventory.Count; i++) { if (pi.myInventory[0].itemName == "StartFourthDay") { return; } }
        chooseClothes.FiveClothes(); }
    private void Start() { if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(26)) { ChangeC(); CheckingClothes(); } }
}