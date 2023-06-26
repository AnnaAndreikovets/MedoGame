using UnityEngine; using UnityEngine.SceneManagement; //устроить проверку на значение договорённости с анжелой 
public class CheckFourthDay : MonoBehaviour { public PlayerInventory pi; public GameObject[] Things; int num1, num2, num3; private Corr corr;
    public void Checking() { for (int i = 0; i < pi.myInventory.Count; i++) { // 26 - наша ; 27 - главный коридор ; 28 - альберта;
// 29 - 2.3; 30- постирончая; 31 - 2.1; 32 - Элизабет; // 33 - Анжелы; 34 - 2.2; 35 - винный погреб // 40 - коридор последний
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(26)) { // 0 - анимация изначальная
// 1 - кнопка для открытия портфеля // 2 - уведомление, когда впервые // 3 - первое описание (М)// 4 - второе описание(М)
// 5  - первое описание (Е1) // 6 - второй описание (Е2) // 7 - кнопка ячейки // 8 - информационная панель // 9 - кнопка открыть рюкзак с инфой о том,
// что я взяла этот портфель потом
            if (pi.myInventory[i].itemName == "StartFourthDay") { Things[0].SetActive(false); Things[8].SetActive(false); }
            else if (pi.myInventory[i].itemName == "KeyForBag2") { Things[1].SetActive(true); Things[2].SetActive(true); Things[9].SetActive(false); }
            else if (pi.myInventory[i].itemName == "OpenBag") { Things[2].SetActive(false); Things[5].SetActive(false);
                Things[6].SetActive(true);}
            else if (pi.myInventory[i].itemName == "ReadInformation") { Things[3].SetActive(false); Things[4].SetActive(true); }
            else if (pi.myInventory[i].itemName == "TakeCellForSafe") { Things[7].SetActive(false); }
            }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(27)) {  // 0 - диаолог со смитом //1 - кнопка выбора 
        int SmitKnow = ((Ink.Runtime.IntValue)DialogueManager.GetInstance().GetVariableState("Gun")).value; if (SmitKnow != 0) { Things[0].SetActive(true);}
            if(pi.myInventory[i].itemName == "Gun") { Things[0].SetActive(false); } 
            if (pi.myInventory[i].itemName == "ResumeButton") { Things[1].SetActive(false);
                    corr = GameObject.FindGameObjectWithTag("Player").GetComponent<Corr>() ; corr.number = 4; corr.SavePos(); } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(28)) { // 0 - кнопка книги // 1 - изображение книги 
// 2 - кнопки для перетаскивания книг // 3 - изображение, что типо нету книги на полке // 4 - бумажка в книге
            if (pi.myInventory[i].itemName == "SolvedBooks") { Things[0].SetActive(true); Things[1].SetActive(true); 
                    Things[2].SetActive(false); Things[3].SetActive(true); }
            if (pi.myInventory[i].itemName == "PaperForSafe") { Things[4].SetActive(false); } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(30)) { //0 - утюг 
// 1 - уведомление для того, что бы положить бумагу //2 - бумага // 3 - препядствие
            if (pi.myInventory[i].itemName == "Smooththiniron") { Things[0].SetActive(false); num1 = 1; } 
            if (pi.myInventory[i].itemName == "PaperForSafe") { num2 = 1; }
            if (num1 == 1 && num2 == 1 && num3 != 1) { Things[1].SetActive(true); }
            if (pi.myInventory[i].itemName == "PaperForSafeOnScene") { Things[1].SetActive(false); Things[2].SetActive(true);
                /*Things[3].SetActive(false); */num3 = 1; } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(31)) {
// 0- кнопка вставить ячейку, 1 - изображение ввер, 2 - изображение вниз, 3 - кнопка ввер, 4 - кнопка вниз // 5 - изображение ячейки
// 6 - открытый сейф // 7 - досье Анжела // 8 - досье второе Анжела // 9 - досье София // 10 - досье второе София // 11 - досье Смит // 12 - досье второе смит
            if (pi.myInventory[i].itemName == "TakeCellForSafe") { Things[0].SetActive(true); }
            else if (pi.myInventory[i].itemName == "PutCellForSafe") { Things[0].SetActive(false); Things[5].SetActive(true);
                Things[1].SetActive(false); Things[2].SetActive(false); Things[3].SetActive(true); Things[4].SetActive(true); }
            else if (pi.myInventory[i].itemName == "SolvedSafe") { Things[6].SetActive(true); }
            }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(32)) { // 0 - изображение ключа // 1 - кнопка ключа
            if (pi.myInventory[i].itemName == "KeyForBag2") { Things[0].SetActive(false); Things[1].SetActive(false); } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(33)) { 
            int agreementShare = ((Ink.Runtime.IntValue)DialogueManager.GetInstance().GetVariableState("agreementShare")).value;
            if (agreementShare != 0) { Things[0].SetActive(true);} }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(34)) { // 0 - тригер для перехода в 2.3
            if (pi.myInventory[i].itemName == "PaperForSafe") { Things[0].SetActive(true); } }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(40)) { // 0 - тригер для перехода в кабинет // 1 - перегородка для нажатия кнопок
                // 2 - панель с цветами
            if (pi.myInventory[i].itemName == "OpenCase") { Things[0].SetActive(true); Things[1].SetActive(true); } 
            if (pi.myInventory[i].itemName == "Rose1" || pi.myInventory[i].itemName == "Rose2") { Things[2].SetActive(false); }  } 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(41)) { 
            if (pi.myInventory[i].itemName == "Rose1") { Things[0].SetActive(true); }
            if (pi.myInventory[i].itemName == "Rose2") { Things[1].SetActive(true); } } } }
    private void Start() => Checking();
}