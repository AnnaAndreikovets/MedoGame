 using UnityEngine; using UnityEngine.SceneManagement;
public class Corr : MonoBehaviour {[SerializeField] public int number, numberOfScene, correctNumber; public VectorValue pos, pos1, pos2, pos3, pos4, 
        pos5, pos6, pos7; //создай новый скрипт, в котором не будет проверки на else при установку позиции 
    public PlayerInventory pi;
    private void Awake()
    { if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(24)) { number = 5; numberOfScene = 24; SavePos(); return; }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(36)) { number = 4; SavePos(); return; }
        for (int i = 1; i <= 5; i++) { if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(i)) { CheckOnAnActiveScene(); } }
        for (int i = 6; i <= 13; i++) { if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(i)) { CheckOnAnActiveScene2(); } }
        for (int i = 14; i <= 25; i++) { if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(i)) { CheckOnAnActiveScene3(); } }
        for (int i = 26; i <= 35; i++) { if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(i)) { CheckOnAnActiveScene4(); } }
        if (number == 1) { pos = pos1; } else if (number == 2) { pos = pos2; }  else if (number == 3) { pos = pos3; }
        else if (number == 4) { pos = pos4; } else if (number == 5) { pos = pos5; } else if (number == 6) { pos = pos6; }
        else if (number == 7) { pos = pos7; } else { LoadPos(); } transform.position = pos.initialValue;
        if (numberOfScene >= 14) { LoadRightNumber(); SavePos(); } SavePos(); }
    public void LoadRightNumber() { number = correctNumber; }
    private void CheckOnAnActiveScene() { //первый день
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(2)) { number = 1; }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(5)) { number = 2; }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(4)) { number = 3; }
        else { LoadPos(); } }
    private void CheckOnAnActiveScene2() { //второй день 
        //коридор второго этажа - 8 //кабирнет - 9 // спа - 10 // комната отдыха - 11 // первая комната - 12
        // наша комната - 13 и 6 // много комнат между собой - 7
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(9)) { number = 2; }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(10)) { number = 3; }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(11)) { number = 4; }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(12)) { number = 1; }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(7)) {
            LoadPos(); if (number == 3) { number = 5; }
            else if (number == 2) { number = 5; }
            else if (number == 4) { number = 5; }
            else if (number == 1 || number == 6) { } }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(8)) {
            LoadPos(); if (number == 2 || number == 3 || number == 4) { }
            else if (number == 1 || number == 6) { number = 5; }}
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(6) ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(13)) { number = 6; }
        else { LoadPos();} } 
    private void CheckOnAnActiveScene3() { LoadPos();
        //большой коридор(14), коридор2.1(15), коридор2.3(16), боилерная(17), сад(18), гладильная(19),бассейн(20), сад2(23), спички(24), сад3(25)
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(14)) { numberOfScene = 14;
            if (number == 6) { number = 1; } else if (number == 2) { number = 2; } else if (number == 4) { number = 3; } 
            else if(number == 5) { number = 4; } correctNumber = 1; } 
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(15)) { numberOfScene = 15;
            if (number == 1) { number = 1; } else if (number == 5) { number = 2; } else if (number == 7) { number = 3; } correctNumber = 2; } 
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(16)) {
            if (number == 6 || number == 5) { number = 1; } else if (number == 4){ number = 2; } correctNumber = 3; numberOfScene = 16;
        } 
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(17)) {
            correctNumber = 4; numberOfScene = 17;
            } 
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(18)) {
            if (number == 2) { number = 1; }
            else if (number == 3) { number = 2; } else if (number == 7) { number = 3; } correctNumber = 2; numberOfScene = 18; } 
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(19)) {
            correctNumber = 6; numberOfScene = 19;
            } 
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(20)) { 
            correctNumber = 7; numberOfScene = 20; } 
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(21)) { 
            correctNumber = 6; numberOfScene = 21;  } 
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(22)) {
            correctNumber = 4; numberOfScene = 22; } 
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(23)) {
            if (number == 7) { number = 1; } else if (number == 3) { number = 2; } else if (number == 2) { number = 3; } correctNumber = 7; numberOfScene = 23; } 
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(25)) { correctNumber = 3; numberOfScene = 25; } }
    private void CheckOnAnActiveScene4() { // 26 - наша ; 27 - главный коридор ; 28 - альберта;
        // 29 - 2.3; 30- постирончая; 31 - 2.1; 32 - Элизабет; // 33 - Анжелы; 34 - 2.2; 35 - винный погреб
        LoadPos();
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(26)) { number = 1; correctNumber = 1; numberOfScene = 26; }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(27)) {
            if (number == 1) { number = 1; } else if (number == 2) { number = 2; } else if (number == 3) { number = 3; } else if (number == 4) { number = 4; }
            correctNumber = 2; for (int i = 0; i < pi.myInventory.Count; i++) { if (pi.myInventory[i].itemName == "Final") { correctNumber = 4; number = 4; } }
            numberOfScene = 27; }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(28)) { number = 1; correctNumber = 1; numberOfScene = 28; }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(29)) { number = 4; correctNumber = 4; numberOfScene = 29; }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(31)) {
            if (number == 2) { number = 1; } else if (number == 4) { number = 2; } correctNumber = 3; numberOfScene = 31; }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(32)) { number = 2; correctNumber = 2; Debug.Log(number); numberOfScene = 32; }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(33)) { number = 2; correctNumber = 2; numberOfScene = 33; }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(34)) { if (number == 1 || number == 3) { number = 1; } 
            else if (number == 2) { number = 2; } else if ( number == 4) { number = 4; } correctNumber = 4; numberOfScene = 34; }  }
    public void SavePos() { SavePosition.SavePos(this);}
    public void LoadPos() { PlayerData data = SavePosition.LoadPos(); number = data.number; }
}