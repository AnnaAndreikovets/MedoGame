using UnityEngine; using UnityEngine.SceneManagement;
public class MainTasksDay3 : MonoBehaviour { public PlayerInventory pi; public ChooseClothes chooseClothes; public GameObject[] blocks; int[] nums = new int[9];
    public TakeStar takeStar;
    private void Start() { CheckListOfTasks(); } 
    public void CheckListOfTasks() { for (int i = 0; i < pi.myInventory.Count; i++) { // 0 -сменить одежду
            // 1 - коробок спичек для свечей(после свечей, убираем когда получаем) 
            if (pi.myInventory[i].itemName == "StartThirdDay" && chooseClothes.numberClothes == 1 || chooseClothes.numberClothes == 2
                || chooseClothes.numberClothes == 3 || chooseClothes.numberClothes == 4) { blocks[0].SetActive(false); }
            if (pi.myInventory[i].itemName == "needABoxMatches") { blocks[1].SetActive(true); }
            if (pi.myInventory[i].itemName == "MatchBox") { blocks[1].SetActive(false); }
            // 2 - спросить про вино (всегда, а исчезает после того как спросили)
            if (pi.myInventory[i].itemName == "Alex4") { blocks[2].SetActive(false); }
            // 3 -обследовать сцену смерти (когда зашли, а после осмотра пропадает)
            // 4 - собрать картину и отыскать сейф (после разговора с альбертом,а всё когда всё соберём)
            // 5 - опрос людей (после того как обследовали сцену, а пропадает после того как всех опросили)
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(25)) { blocks[3].SetActive(true); }
            if (pi.myInventory[i].itemName == "InspectTheCrimeScene2") { blocks[3].SetActive(false); blocks[5].SetActive(true); }
            if (pi.myInventory[i].itemName == "MurderSmit2") { nums[3] = 1; }
            if (pi.myInventory[i].itemName == "2MurderSofia&Elizabet") { nums[4] = 1; }
            if (pi.myInventory[i].itemName == "MurderAnzela2") { nums[5] = 1; }
            if (pi.myInventory[i].itemName == "MurderAlbert2") { nums[6] = 1; }
            if (pi.myInventory[i].itemName == "MurderAlex2") { nums[7] = 1; nums[8] = 1; blocks[4].SetActive(true); }
            if (nums[3] == 1 && nums[4] == 1 && nums[5] == 1 && nums[6] == 1 && nums[7] == 1) { blocks[5].SetActive(false); }
            if (pi.myInventory[i].itemName == "OpenSafe" && nums[8] == 1) { blocks[4].SetActive(false); }
            // 6 - починить водопровод (когда смит попросил об этом, а пропадает после того как починили)
            // 7 -найти предохранители и вставить (после того как смит попросит об этом, а исчезнет когда все три будут поставлены)
            if (pi.myInventory[i].itemName == "Helping") { blocks[7].SetActive(true); blocks[6].SetActive(true); }
            if (pi.myInventory[i].itemName == "FuseOnScene") { nums[0] = 1; }
            if (pi.myInventory[i].itemName == "PutFuse2") { nums[1] = 1; }
            if (pi.myInventory[i].itemName == "PutFuse3") { nums[2] = 1; }
            if (pi.myInventory[i].itemName == "Level2") { blocks[6].SetActive(false); }
            if (nums[1] == 1 && nums[2] == 1 && nums[2] == 1) { blocks[7].SetActive(false); } } }
}