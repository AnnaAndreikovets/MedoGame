using UnityEngine; using UnityEngine.SceneManagement;
public class ChooseClothes : MonoBehaviour { [SerializeField]public int numberClothes; public Animator anim, anim2;
    private void Awake() { LoadCl(); ChooseClothes_(); SaveCl(); }
    public void FirstClothes() { numberClothes = 1;  SaveCl(); ChooseClothes_(); }
    public void SecondClothes() { numberClothes = 2; SaveCl(); ChooseClothes_(); }
    public void ThirdClothes() { numberClothes = 3; SaveCl(); ChooseClothes_(); }
    public void FourClothes() { numberClothes = 4;  SaveCl(); ChooseClothes_(); }
    public void FiveClothes() { numberClothes = 5; SaveCl(); ChooseClothes_(); }
    public void SixthClothes() { numberClothes = 6; SaveCl(); ChooseClothes_(); }
    public void ChooseClothes_() { if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1) || SceneManager.GetActiveScene() ==
        SceneManager.GetSceneByBuildIndex(2) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3) || SceneManager.GetActiveScene() == 
        SceneManager.GetSceneByBuildIndex(4) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(5) ) { numberClothes = 2; SaveCl(); }
        if (numberClothes == 1) { anim.SetTrigger("change1"); } else if (numberClothes == 2) { anim.SetTrigger("change2"); } 
        else if (numberClothes == 3) { anim.SetTrigger("change3"); } else if (numberClothes == 4) { anim.SetTrigger("change4"); }
        else if (numberClothes == 5) { anim.SetTrigger("change5"); } else if (numberClothes == 6) { anim.SetTrigger("change6"); } 
        else { Debug.Log("Index of animation is uncorrected"); } SaveCl(); }
    public void SaveCl() { SaveClothes.SaveClothes_(this); }
    public void LoadCl() { ClothesData data = SaveClothes.LoadClothes(); numberClothes = data.numberClothes; }
}