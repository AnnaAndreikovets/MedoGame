using UnityEngine; using UnityEngine.SceneManagement;
public class CheckThirdDay : MonoBehaviour { public PlayerInventory pi; public GameObject[] Things; int num1, num2, num3; public OpenFuse openFuse;
    public void SetActive() { for (int p = 0; p < pi.myInventory.Count; p++) {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(14)) {
// 0 - кнопка войти комната 4 // 1 - разговор про убийство смит// 2 - разговор про спички первый // 3 - разговор про спички второй
// 4 - разговор про убийстов анжела // 5 - разговор про убийства альберта// 6 - сам смит // 7 - с и е // 8 - анжела // 9 - изображение коробка 
// 10 - кнопка для вывода сообщения о коробке // 11 - разговор про помощь
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
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(15)) { // 0 - то что мешает нам нажимать на кнопки если нету части карлтины 
// 1 - уведомление  // 2 - сама часть картины // 4 - завершённая картина // 5 - уведомление отодвинуть // 3 - уведомление вставить // 6 - лицо на сцене
// 7 - сам сейф // 8 - весь канвас картины // 9 - завёршённая картина на сцене
            if (pi.myInventory[p].itemName == "PictureOnScene") { Things[0].SetActive(false); Things[1].SetActive(false); Things[3].SetActive(true); } 
            if (pi.myInventory[p].itemName == "MurderAlex2") { num1 = 1; }
            if (pi.myInventory[p].itemName == "PathInPicture") { Things[3].SetActive(false); Things[2].SetActive(true); Things[6].SetActive(true); }
            if (pi.myInventory[p].itemName == "SolvedPicture") { Things[4].SetActive(true); Things[9].SetActive(true);
                    if (num1 == 1) { Things[5].SetActive(true); } }
            if (pi.myInventory[p].itemName == "OpenSafe") { Things[7].SetActive(true); Things[4].SetActive(false); Things[5].SetActive(false); } }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(17)){
// 0 - анмматор вставить предохранитель // 1- предохранитель в коробке на сцене // 2 - первый уровень в трубах // 3 - второй уровень в трубах
// 4 - панель победы певрого уровня // 5 - панель победы второго уровня // 6 - кнопка взять звезду // 7 -уведомление о трубах
// 8 - аниматор вставить предохранитель2 // 9 - второй предохранитель на сцене 2// 10 - аниматор вставить 3 // 11 - третьий предох на сцене
// 12 - кнопка начать собирать водопровод
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
// 0 - уведомление о выкопать // 1 - яма // 2 - предохранитель в яме // 3- кнопкаВзять // 4 - текстТрава // 5 - текстЯма 
//6 - разговор с Алексом после убийства // 7 - разговр про вино
                if (pi.myInventory[p].itemName == "Shovel") { Things[0].SetActive(true); }
                else if (pi.myInventory[p].itemName == "Pit") { Things[0].SetActive(false); Things[1].SetActive(true); Things[3].SetActive(true);
                    Things[4].SetActive(false); Things[5].SetActive(true); }
                else if (pi.myInventory[p].itemName == "Fuse") { Things[2].SetActive(false); Things[3].SetActive(false); } 
                else if (pi.myInventory[p].itemName == "InspectTheCrimeScene2") { Things[6].SetActive(true); }
                else if (pi.myInventory[p].itemName == "MurderAlex2") { Things[6].SetActive(false); } 
                else if(pi.myInventory[p].itemName == "Alex4") { Things[7].SetActive(false); } }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(19)) { 
// 4 - диалог про убийства // 5 - сами девушки (содержит в себе всё для старата диалога)// 6 - кнопка для инфы про то что стоит на полках
// 7 - изображение сцены для анимация (с белым квадратом) // 8 - анимация крутяшки // 9 - канвас с изображениями девушек // 10 - звук стиралки
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
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(21)) { // 0 - анимация начатого третьего дня
    // 1 - панель информации третьего дня // 2 - папака вторая // 3 - (у) анжела // 4 - (у) - софия// 5 -(у) лиза // 6 - (у) альберт 
    // 7 - (у) - адам // 8 - (у) - смит // 9 - (у) - алекс // 10 - (у) - кетрин // 11 - текст первый(мартин) // 12 - текст второй (мартин)
    // 13 - текст первый(вилсон) // 14 - текст второй (вилсон) // 15 - кнопка посмотреть инфу про трубы // 16 - вода на сцене // 17 - звук воды на сцене
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
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(23)) { //0 - уведомление о спичках //1 - панель перекрывющая кнопки
// 2 - панель завершённая // 3 - секретная полка // 4 - кнопка для подбора предохранителя // 5 - панель не завершённая // 6 - свечи на сцене
//7 - изображение предохранителя // 8 - стрелка до обноружения тела // 9- стрелка после обноружения тела // 10 - Audio Sources звук огня
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
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(25)) { // 0 - втворой разговор 
// 1 - первый разговор // 2 - инфа про клумбы // 3 - инфа про лес // 4 - инфа про труп // 5 - стрелочка с уведомление // 6 - стрелочка с переходом
            if (pi.myInventory[p].itemName == "InspectTheCrimeScene2") { Things[0].SetActive(false); Things[3].SetActive(true);
                    Things[2].SetActive(true); Things[4].SetActive(true); Things[5].SetActive(false); Things[6].SetActive(true); }
            else if (pi.myInventory[p].itemName == "MurderMaks2") { Things[1].SetActive(false);} } } }
    private void Start() { SetActive(); }
}