using UnityEngine; using UnityEngine.SceneManagement; //�������� �������� �� �������� ������������� � ������� 
public class CheckFourthDay : MonoBehaviour { public PlayerInventory pi; public GameObject[] Things; int num1, num2, num3; private Corr corr;
    public void Checking() { for (int i = 0; i < pi.myInventory.Count; i++) { // 26 - ���� ; 27 - ������� ������� ; 28 - ��������;
// 29 - 2.3; 30- �����������; 31 - 2.1; 32 - ��������; // 33 - ������; 34 - 2.2; 35 - ������ ������ // 40 - ������� ���������
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(26)) { // 0 - �������� �����������
// 1 - ������ ��� �������� �������� // 2 - �����������, ����� ������� // 3 - ������ �������� (�)// 4 - ������ ��������(�)
// 5  - ������ �������� (�1) // 6 - ������ �������� (�2) // 7 - ������ ������ // 8 - �������������� ������ // 9 - ������ ������� ������ � ����� � ���,
// ��� � ����� ���� �������� �����
            if (pi.myInventory[i].itemName == "StartFourthDay") { Things[0].SetActive(false); Things[8].SetActive(false); }
            else if (pi.myInventory[i].itemName == "KeyForBag2") { Things[1].SetActive(true); Things[2].SetActive(true); Things[9].SetActive(false); }
            else if (pi.myInventory[i].itemName == "OpenBag") { Things[2].SetActive(false); Things[5].SetActive(false);
                Things[6].SetActive(true);}
            else if (pi.myInventory[i].itemName == "ReadInformation") { Things[3].SetActive(false); Things[4].SetActive(true); }
            else if (pi.myInventory[i].itemName == "TakeCellForSafe") { Things[7].SetActive(false); }
            }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(27)) {  // 0 - ������� �� ������ //1 - ������ ������ 
        int SmitKnow = ((Ink.Runtime.IntValue)DialogueManager.GetInstance().GetVariableState("Gun")).value; if (SmitKnow != 0) { Things[0].SetActive(true);}
            if(pi.myInventory[i].itemName == "Gun") { Things[0].SetActive(false); } 
            if (pi.myInventory[i].itemName == "ResumeButton") { Things[1].SetActive(false);
                    corr = GameObject.FindGameObjectWithTag("Player").GetComponent<Corr>() ; corr.number = 4; corr.SavePos(); } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(28)) { // 0 - ������ ����� // 1 - ����������� ����� 
// 2 - ������ ��� �������������� ���� // 3 - �����������, ��� ���� ���� ����� �� ����� // 4 - ������� � �����
            if (pi.myInventory[i].itemName == "SolvedBooks") { Things[0].SetActive(true); Things[1].SetActive(true); 
                    Things[2].SetActive(false); Things[3].SetActive(true); }
            if (pi.myInventory[i].itemName == "PaperForSafe") { Things[4].SetActive(false); } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(30)) { //0 - ���� 
// 1 - ����������� ��� ����, ��� �� �������� ������ //2 - ������ // 3 - �����������
            if (pi.myInventory[i].itemName == "Smooththiniron") { Things[0].SetActive(false); num1 = 1; } 
            if (pi.myInventory[i].itemName == "PaperForSafe") { num2 = 1; }
            if (num1 == 1 && num2 == 1 && num3 != 1) { Things[1].SetActive(true); }
            if (pi.myInventory[i].itemName == "PaperForSafeOnScene") { Things[1].SetActive(false); Things[2].SetActive(true);
                /*Things[3].SetActive(false); */num3 = 1; } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(31)) {
// 0- ������ �������� ������, 1 - ����������� ����, 2 - ����������� ����, 3 - ������ ����, 4 - ������ ���� // 5 - ����������� ������
// 6 - �������� ���� // 7 - ����� ������ // 8 - ����� ������ ������ // 9 - ����� ����� // 10 - ����� ������ ����� // 11 - ����� ���� // 12 - ����� ������ ����
            if (pi.myInventory[i].itemName == "TakeCellForSafe") { Things[0].SetActive(true); }
            else if (pi.myInventory[i].itemName == "PutCellForSafe") { Things[0].SetActive(false); Things[5].SetActive(true);
                Things[1].SetActive(false); Things[2].SetActive(false); Things[3].SetActive(true); Things[4].SetActive(true); }
            else if (pi.myInventory[i].itemName == "SolvedSafe") { Things[6].SetActive(true); }
            }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(32)) { // 0 - ����������� ����� // 1 - ������ �����
            if (pi.myInventory[i].itemName == "KeyForBag2") { Things[0].SetActive(false); Things[1].SetActive(false); } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(33)) { 
            int agreementShare = ((Ink.Runtime.IntValue)DialogueManager.GetInstance().GetVariableState("agreementShare")).value;
            if (agreementShare != 0) { Things[0].SetActive(true);} }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(34)) { // 0 - ������ ��� �������� � 2.3
            if (pi.myInventory[i].itemName == "PaperForSafe") { Things[0].SetActive(true); } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(40)) { // 0 - ������ ��� �������� � ������� // 1 - ����������� ��� ������� ������
                // 2 - ������ � �������
            if (pi.myInventory[i].itemName == "OpenCase") { Things[0].SetActive(true); Things[1].SetActive(true); } 
            if (pi.myInventory[i].itemName == "Rose1" || pi.myInventory[i].itemName == "Rose2") { Things[2].SetActive(false); }  } 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(41)) { 
            if (pi.myInventory[i].itemName == "Rose1") { Things[0].SetActive(true); }
            if (pi.myInventory[i].itemName == "Rose2") { Things[1].SetActive(true); } } } }
    private void Start() => Checking();
}