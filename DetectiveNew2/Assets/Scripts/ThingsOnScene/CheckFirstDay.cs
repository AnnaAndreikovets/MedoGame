using UnityEngine.SceneManagement; using UnityEngine;
public class CheckFirstDay : MonoBehaviour { public GameObject[] Things; public PlayerInventory pi; public int num1, num2;
    public void Checking() {  // 1 - ������� // 2 - �������� ����� // 3 - ������� ������� // 4 - ���� ������� // 5 - ������� �������
    for (int i = 0; i < pi.myInventory.Count; i++) {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1)) { // 0 - ������ ���� � ������� 
// 1 - ��������� ������ ������ // 2 - ������ ����������� // 3 - ������ ����������� // 4 - ������� ������� // 5 - ������ �������� ������ � �������
            if (pi.myInventory[i].itemName == "Gun") { Things[1].SetActive(false); num1 = 1; } 
            if (pi.myInventory[i].itemName == "Letter") { num2 = 1; } 
            if(num1 == 1 && num2 == 1) { Things[2].SetActive(false); Things[3].SetActive(true); }
            if(pi.myInventory[i].itemName == "Information") { Things[0].SetActive(false); } 
            if(pi.myInventory[i].itemName == "OpenCase") { Things[4].SetActive(true); Things[5].SetActive(false); } } 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(2)) { // 0 - ������ ������  
// 1 - ����������� ���� �� ����� // 2 - ������ ����� � ��� // 3 - ������ ����������� // 4 - ������ // ���� ������
            if (pi.myInventory[i].itemName == "Bag") { Things[0].SetActive(false); Things[3].SetActive(false);
                    Things[2].SetActive(true); Things[1].SetActive(false); } 
            if(pi.myInventory[i].itemName == "Car") { Things[4].SetActive(false); Things[5].SetActive(false); } } 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3)) { // 0 - �������� �� ������ 
// 1 - ������ ����� � ���� �������  // 2 - ����������� ���� �� ����� ���� // 3 - ������ ����� � ����� // 4 - ����������� ������ � �����
// 5 - ������� � �������� � �������� 
            if (pi.myInventory[i].itemName == "FirstSmit") { Things[0].SetActive(false); Things[1].SetActive(true); 
                Things[2].SetActive(false); }
            if (pi.myInventory[i].itemName == "ThingsOnSceneR3") { Things[3].SetActive(true); Things[4].SetActive(false); }
            if (pi.myInventory[i].itemName == "Star2") { Things[5].SetActive(false); } } 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(4)) { // 0 - ��������� ������ // 1 - ������ � ������ 
// 2 - ��������� ������ // 3 - ������ ��������� // 4 - ������ ������� ������ // 
            if (pi.myInventory[i].itemName == "ThingsOnSceneR3") { Things[0].SetActive(true); Things[1].SetActive(true); 
                Things[3].SetActive(false); }
            if (pi.myInventory[i].itemName == "Star1") { Things[2].SetActive(false); } 
            if (pi.myInventory[i].itemName == "KeyForBag") { Things[0].SetActive(false); Things[4].SetActive(true); } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(5)) { // 0 - �������� � ������� // 1 - ������ ��������� �����
// 2 - ������ ��� ������� ����� // 3 - ���� ������ � ������� ����� ������ ������ ����. // 4 - �����������, ��� ����� ����� // 5 - ����������� ������ ����� 
// 6 - ������ ��� ����� �����
            if (pi.myInventory[i].itemName == "KeyForBag") { if(Things[2] != null)Things[2].SetActive(false); }
            if (pi.myInventory[i].itemName == "Maks") { Things[0].SetActive(false); Things[4].SetActive(true); Things[6].SetActive(true); }
            if (pi.myInventory[i].itemName == "Desk") { Things[3].SetActive(true); if (Things[1] != null)  Things[1].SetActive(false); 
                Things[4].SetActive(false); if (Things[5] != null) Things[5].SetActive(false); Things[6].SetActive(false); } 
            if (pi.myInventory[i].itemName == "SolvedDesk") { Things[3].SetActive(false); } } 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(36)) {  
// 0 - ����� // 1 - ����� // 2 - ������ // 3 - ����� // 4 - ������ // 5 ����� ������ // 6  - ���������� ������
            if (pi.myInventory[i].itemName == "SolvedMaze") { Things[0].SetActive(false); Things[1].SetActive(false); 
                Things[2].SetActive(false); Things[3].SetActive(false); Things[4].SetActive(false); Things[6].SetActive(true); } 
            if (pi.myInventory[i].itemName == "Star2") { Things[5].SetActive(false); } } 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(37)) {  // 0 - ������
            if (pi.myInventory[i].itemName == "Star3") { Things[0].SetActive(false); } }  } }
    private void Start() => Checking();
}