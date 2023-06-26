using UnityEngine.SceneManagement; using UnityEngine;
public class StartThirdDay : MonoBehaviour { public GameObject arrowForExit, arrow, triggerForNotification; public ChooseClothes chooseClothes;
    public PlayerInventory pi;
    public void CheckingClothes() { if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(21) && chooseClothes.numberClothes != 5) {
            arrowForExit.SetActive(true); arrow.SetActive(false); triggerForNotification.SetActive(false); } }
    public void ChangeC() { for (int i = 0; i < pi.myInventory.Count; i++) { if (pi.myInventory[i].itemName == "StartThirdDay") { return; } }
        chooseClothes.FiveClothes(); }
    private void Start() { if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(21)) { CheckingClothes(); ChangeC(); } }
}