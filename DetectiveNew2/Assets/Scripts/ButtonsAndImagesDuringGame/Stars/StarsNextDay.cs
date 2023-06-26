using UnityEngine; using System.IO; using UnityEngine.SceneManagement;
public class StarsNextDay : MonoBehaviour { public PlayerInventory myStars;
    bool star1 = false; bool star2 = false; bool star3 = false; public GameObject notification; public GameObject bedB; public GameObject bedNS;
    void CheckingStars() { if (myStars) { for (int i = 0; i < myStars.myStars.Count; i++)
            { if (myStars.myStars[i].nameOfItem == "Star1") { star1 = true; }
                if (myStars.myStars[i].nameOfItem == "Star2") { star2 = true; }
                if (myStars.myStars[i].nameOfItem == "Star3") { star3 = true; } } } }
    public void ShowNotification() { if (star1 == true && star2 == true && star3 == true) {
            notification.SetActive(true);
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(4))
            { bedB.SetActive(false);  bedNS.SetActive(true); }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(13)) { bedNS.SetActive(true); } } }
    public void ResetScriptables() { int i = 0; while (File.Exists(Application.persistentDataPath + string.Format("/{0}.inv", i)))
        { File.Delete(Application.persistentDataPath + string.Format("/{0}.inv", i)); i++; } if(myStars)myStars.myInventory2.Clear(); }
    public void ResetScriptables2() { int i = 0; while (File.Exists(Application.persistentDataPath + string.Format("/{0}.thin", i)))
        { File.Delete(Application.persistentDataPath + string.Format("/{0}.thin", i)); i++; } if(myStars)myStars.myInventory.Clear(); }
    public void ResetScriptables3() { int i = 0; while (File.Exists(Application.persistentDataPath + string.Format("/{0}.star", i)))
        { File.Delete(Application.persistentDataPath + string.Format("/{0}.star", i)); i++; } if(myStars)myStars.myStars.Clear(); }
    private void Update() { CheckingStars(); ShowNotification(); }
}