using UnityEngine; using UnityEngine.SceneManagement;
public class CheckThirdDay : MonoBehaviour { public PlayerInventory pi; public GameObject[] Things; int num1, num2, num3; public OpenFuse openFuse;
    public void SetActive() { for (int p = 0; p < pi.myInventory.Count; p++) {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(14)) {
// 0 - ������ ����� ������� 4 // 1 - �������� ��� �������� ����// 2 - �������� ��� ������ ������ // 3 - �������� ��� ������ ������
// 4 - �������� ��� �������� ������ // 5 - �������� ��� �������� ��������// 6 - ��� ���� // 7 - � � � // 8 - ������ // 9 - ����������� ������� 
// 10 - ������ ��� ������ ��������� � ������� // 11 - �������� ��� ������
            if (pi.myInventory[p].itemName == "InspectTheCrimeScene2") { Things[0].SetActive(true); Things[5].SetActive(true); Things[6].SetActive(true);
                Things[4].SetActive(true); Things[7].SetActive(false); Things[8].SetActive(true); }
            else if(pi.myInventory[p].itemName == "2MurderSofia&Elizabet") { Things[1].SetActive(true); }
            else if (pi.myInventory[p].itemName == "MurderSmit2") { Things[1].SetActive(false); } 
            else if (pi.myInventory[p].itemName == "needABoxMatches") { Things[2].SetActive(true); }
            else if (pi.myInventory[p].itemName == "ConvMatch1") { Things[2].SetActive(false); Things[3].SetActive(true); }
            else if (pi.myInventory[p].itemName == "MatchBox") { Things[3].SetActive(false); Things[9].SetActive(false); Things[10].SetActive(false); }
            else if (pi.myInventory[p].itemName == "MurderAnzela2") { Things[4].SetActive(false); }
            else if (pi.myInventory[p].itemName == "MurderAlbert2") { Things[5].SetActive(false); }  
            else if (pi.myInventory[p].itemName == "Helping") { Things[11].SetActive(false); }  
            }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(15)) { // 0 - �� ��� ������ ��� �������� �� ������ ���� ���� ����� �������� 
// 1 - �����������  // 2 - ���� ����� ������� // 4 - ����������� ������� // 5 - ����������� ���������� // 3 - ����������� �������� // 6 - ���� �� �����
// 7 - ��� ���� // 8 - ���� ������ ������� // 9 - ���������� ������� �� �����
            if (pi.myInventory[p].itemName == "PictureOnScene") { Things[0].SetActive(false); Things[1].SetActive(false); Things[3].SetActive(true); } 
            if (pi.myInventory[p].itemName == "MurderAlex2") { num1 = 1; }
            if (pi.myInventory[p].itemName == "PathInPicture") { Things[3].SetActive(false); Things[2].SetActive(true); Things[6].SetActive(true); }
            if (pi.myInventory[p].itemName == "SolvedPicture") { Things[4].SetActive(true); Things[9].SetActive(true);
                    if (num1 == 1) { Things[5].SetActive(true); } }
            if (pi.myInventory[p].itemName == "OpenSafe") { Things[7].SetActive(true); Things[4].SetActive(false); Things[5].SetActive(false); } }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(17)){
// 0 - �������� �������� �������������� // 1- �������������� � ������� �� ����� // 2 - ������ ������� � ������ // 3 - ������ ������� � ������
// 4 - ������ ������ ������� ������ // 5 - ������ ������ ������� ������ // 6 - ������ ����� ������ // 7 -����������� � ������
// 8 - �������� �������� ��������������2 // 9 - ������ �������������� �� ����� 2// 10 - �������� �������� 3 // 11 - ������� ������ �� �����
// 12 - ������ ������ �������� ����������
                if (pi.myInventory[p].itemName == "Helping") { num1 = 1; Things[12].SetActive(true); }
                else if (pi.myInventory[p].itemName == "Fuse" && num1 == 1 && openFuse.num == 1) { Things[0].SetActive(true); }
                else if (pi.myInventory[p].itemName == "FuseOnScene") { Things[1].SetActive(true); Things[0].SetActive(false); }
                else if (pi.myInventory[p].itemName == "Level1") { Things[2].SetActive(false); Things[4].SetActive(true); Things[7].SetActive(false);}
                else if (pi.myInventory[p].itemName == "Level2") { Things[3].SetActive(false); Things[5].SetActive(true); Things[4].SetActive(false); 
                    Things[7].SetActive(false); }
                else if (pi.myInventory[p].itemName == "Star1") { Things[6].SetActive(false); }
                else if (pi.myInventory[p].itemName == "TakeFuse2" && num1 == 1 && openFuse.num == 1) { Things[8].SetActive(true); }
                else if (pi.myInventory[p].itemName == "PutFuse2") { Things[9].SetActive(true); Things[8].SetActive(false); }
                else if (pi.myInventory[p].itemName == "TakeFuse3" && num1 == 1 && openFuse.num == 1) { Things[10].SetActive(true); }
                else if (pi.myInventory[p].itemName == "PutFuse3") { Things[11].SetActive(true); Things[10].SetActive(false); }
            }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(18)) {
// 0 - ����������� � �������� // 1 - ��� // 2 - �������������� � ��� // 3- ����������� // 4 - ���������� // 5 - �������� 
//6 - �������� � ������� ����� �������� // 7 - ������� ��� ����
                if (pi.myInventory[p].itemName == "Shovel") { Things[0].SetActive(true); }
                else if (pi.myInventory[p].itemName == "Pit") { Things[0].SetActive(false); Things[1].SetActive(true); Things[3].SetActive(true);
                    Things[4].SetActive(false); Things[5].SetActive(true); }
                else if (pi.myInventory[p].itemName == "Fuse") { Things[2].SetActive(false); Things[3].SetActive(false); } 
                else if (pi.myInventory[p].itemName == "InspectTheCrimeScene2") { Things[6].SetActive(true); }
                else if (pi.myInventory[p].itemName == "MurderAlex2") { Things[6].SetActive(false); } 
                else if(pi.myInventory[p].itemName == "Alex4") { Things[7].SetActive(false); } }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(19)) { 
// 4 - ������ ��� �������� // 5 - ���� ������� (�������� � ���� �� ��� ������� �������)// 6 - ������ ��� ���� ��� �� ��� ����� �� ������
// 7 - ����������� ����� ��� �������� (� ����� ���������) // 8 - �������� �������� // 9 - ������ � ������������� ������� // 10 - ���� ��������
            if (pi.myInventory[p].itemName == "Shovel") { Things[0].SetActive(false); Things[1].SetActive(false); }
            else if (pi.myInventory[p].itemName == "PoolNet") { Things[2].SetActive(false); Things[3].SetActive(false); } 
            else if (pi.myInventory[p].itemName == "InspectTheCrimeScene2") { Things[4].SetActive(true); Things[5].SetActive(true); Things[6].SetActive(true);
                Things[9].SetActive(true); }
            else if (pi.myInventory[p].itemName == "2MurderSofia&Elizabet") { Things[4].SetActive(false); }
            else if (pi.myInventory[p].itemName == "FuseOnScene") { num1 = 1; }
            else if (pi.myInventory[p].itemName == "PutFuse2") { num2 = 1; }
            else if (pi.myInventory[p].itemName == "PutFuse3") { num3 = 1; }
            if (num1 == 1 && num2 == 1 && num3 == 1) { Things[7].SetActive(true); Things[8].SetActive(true); Things[10].SetActive(true); } }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(20)) {
            if (pi.myInventory[p].itemName == "PictureOnScene") { Things[0].SetActive(false); Things[1].SetActive(false); }
            else if (pi.myInventory[p].itemName == "PoolNet") { Things[2].SetActive(false); } 
            else if (pi.myInventory[p].itemName == "Level2") { Things[3].SetActive(true); Things[4].SetActive(true); Things[5].SetActive(true);
                Things[6].SetActive(true); Things[7].SetActive(true); } }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(21)) { // 0 - �������� �������� �������� ���
    // 1 - ������ ���������� �������� ��� // 2 - ������ ������ // 3 - (�) ������ // 4 - (�) - �����// 5 -(�) ���� // 6 - (�) ������� 
    // 7 - (�) - ���� // 8 - (�) - ���� // 9 - (�) - ����� // 10 - (�) - ������ // 11 - ����� ������(������) // 12 - ����� ������ (������)
    // 13 - ����� ������(������) // 14 - ����� ������ (������) // 15 - ������ ���������� ���� ��� ����� // 16 - ���� �� ����� // 17 - ���� ���� �� �����
            if(pi.myInventory[p].itemName == "StartThirdDay") { Things[0].SetActive(false); Things[1].SetActive(false); }
            else if (pi.myInventory[p].itemName == "InspectTheCrimeScene2") { Things[2].SetActive(true); Things[11].SetActive(false);
                    Things[12].SetActive(true); }
            else if (pi.myInventory[p].itemName == "MurderSmit2") { Things[8].SetActive(true); num1 = 1; }
            else if (pi.myInventory[p].itemName == "2MurderSofia&Elizabet") { Things[4].SetActive(true); Things[5].SetActive(true); num2 = 1; }
            else if (pi.myInventory[p].itemName == "MurderAnzela2") { Things[3].SetActive(true); }
            else if (pi.myInventory[p].itemName == "MurderAlbert2") { Things[6].SetActive(true); Things[7].SetActive(true); Things[10].SetActive(true); }
            else if (pi.myInventory[p].itemName == "MurderAlex2") { Things[9].SetActive(true); } 
            else if (num1 == 1 && num2 == 1) { Things[13].SetActive(false); Things[14].SetActive(true); }
            else if (pi.myInventory[p].itemName == "Level2") { Things[15].SetActive(false); Things[16].SetActive(false); Things[17].SetActive(false); } }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(22)) {
            if (pi.myInventory[p].itemName == "TakeFuse3") { Things[0].SetActive(false); Things[1].SetActive(false); } }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(23)) { //0 - ����������� � ������� //1 - ������ ������������ ������
// 2 - ������ ����������� // 3 - ��������� ����� // 4 - ������ ��� ������� �������������� // 5 - ������ �� ����������� // 6 - ����� �� �����
//7 - ����������� �������������� // 8 - ������� �� ����������� ���� // 9- ������� ����� ����������� ���� // 10 - Audio Sources ���� ����
            if (pi.myInventory[p].itemName == "MatchBox") { Things[0].SetActive(false); Things[1].SetActive(false);}
            else if (pi.myInventory[p].itemName == "SolvedCandles") { Things[2].SetActive(true); Things[3].SetActive(true); Things[4].SetActive(true);
                Things[5].SetActive(false); Things[6].SetActive(true); Things[7].SetActive(true); Things[10].SetActive(true); }
            else if (pi.myInventory[p].itemName == "TakeFuse2") { Things[4].SetActive(false); Things[7].SetActive(false); } 
            else if (pi.myInventory[p].itemName == "InspectTheCrimeScene2") { Things[8].SetActive(false); Things[9].SetActive(true); } } 
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(24)) {
            if (pi.myInventory[p].itemName == "FirstLevelBookMatches") { Things[0].SetActive(true); }
            else if (pi.myInventory[p].itemName == "SecondLevelBookMatches") { Things[0].SetActive(false); Things[1].SetActive(true); }
            else if (pi.myInventory[p].itemName == "ThirdLevelBookMatches") { Things[0].SetActive(false); Things[1].SetActive(false);
                Things[2].SetActive(true); } } 
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(25)) { // 0 - ������� �������� 
// 1 - ������ �������� // 2 - ���� ��� ������ // 3 - ���� ��� ��� // 4 - ���� ��� ���� // 5 - ��������� � ����������� // 6 - ��������� � ���������
            if (pi.myInventory[p].itemName == "InspectTheCrimeScene2") { Things[0].SetActive(false); Things[3].SetActive(true);
                    Things[2].SetActive(true); Things[4].SetActive(true); Things[5].SetActive(false); Things[6].SetActive(true); }
            else if (pi.myInventory[p].itemName == "MurderMaks2") { Things[1].SetActive(false);} } } }
    private void Start() { SetActive(); }
}