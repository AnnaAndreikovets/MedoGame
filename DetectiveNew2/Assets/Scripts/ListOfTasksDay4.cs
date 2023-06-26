using UnityEngine; using UnityEngine.SceneManagement;
//0 - переодется / 1 - попытаться открыть сейф/ 2 - просмотреть фотографии/ 3 - выбрать к кому стоит присмотерться/ 4- проявить послание / 5 -найти от чего ключ
// 6 - спуститься в погреб
public class ListOfTasksDay4 : MonoBehaviour { public PlayerInventory myList; public GameObject[] blocks; private int[] value = new int[4] { 0, 0, 0, 0 };
    public ChooseClothes chooseClothes;
    private void Update() { if (value[/*было 4*/3] != 1) { Checking(); } if(SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(27))
        for (int i = 0; i < myList.myInventory.Count; i++) { if (myList.myInventory[i].itemName == "Final") { blocks[6].SetActive(true); value[3] = 1; } } }
    public void Checking() { for (int i = 0; i < myList.myInventory.Count; i++) { 
        if (myList.myInventory[i].itemName == "StartThirdDay" && chooseClothes.numberClothes == 1  || chooseClothes.numberClothes == 2 
                || chooseClothes.numberClothes == 3 || chooseClothes.numberClothes == 4) { blocks[0].SetActive(false); }
        if (myList.myInventory[i].itemName == "OpenSafe") { blocks[1].SetActive(false); blocks[3].SetActive(true); }
            int agreementShare = ((Ink.Runtime.IntValue)DialogueManager.GetInstance().GetVariableState("agreementShare")).value;
                if (agreementShare == 1 && value[0] != 1) { blocks[2].SetActive(true); }
        if (myList.myInventory[i].itemName == "SawThePhotos") { blocks[2].SetActive(false); value[0] = 1; }
        if (myList.myInventory[i].itemName == "PaperForSafe" && value[1] != 1) { blocks[4].SetActive(true); }
        if (myList.myInventory[i].itemName == "PaperForSafeOnScene") { blocks[4].SetActive(false); value[1] = 1; }
        if (myList.myInventory[i].itemName == "KeyForBag2" && value[2] != 1) { blocks[5].SetActive(true); }
        if (myList.myInventory[i].itemName == "OpenBag") { blocks[5].SetActive(false); value[2] = 1; } } }
}