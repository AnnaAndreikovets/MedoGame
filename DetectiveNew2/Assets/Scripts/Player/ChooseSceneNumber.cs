using UnityEngine; using UnityEngine.SceneManagement;
public class ChooseSceneNumber : MonoBehaviour { [SerializeField] public int numberScene, numberAnotherScene;
    private void Start() { if (SceneManager.GetActiveScene() != SceneManager.GetSceneByBuildIndex(0)) SaveCl(); Time.timeScale = 1f; }
    public void LoadTheLastScene() { LoadCl(); SceneManager.LoadSceneAsync(numberScene); Time.timeScale = 1f; }
    public void ChangeNumberOfNextDay() { numberScene = numberAnotherScene; SaveCl(); }
    public void SaveCl() { SaveScene.SaveScene_(this); }
    public void LoadCl() { ScenesDate data = SaveScene.LoadScene(); numberScene = data.numberScene; }
}