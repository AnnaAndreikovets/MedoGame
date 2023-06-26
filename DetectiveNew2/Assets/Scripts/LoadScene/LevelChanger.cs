using System.Collections; using UnityEngine; using UnityEngine.SceneManagement; using UnityEngine.UI;

public class LevelChanger : MonoBehaviour { private Animator anim; public string levelToLoad; public Vector3 position; 
    public VectorValue playerStorage; public Slider slider; public GameObject loadingScreen;
    private void Start() => anim = GetComponent<Animator>();
    public void FadeToLevel() => anim.SetTrigger("fade");
    public void OnFadeComplete() { playerStorage.initialValue = position; SceneManager.LoadScene(levelToLoad); StartCoroutine(LoadingScreenOnFade()); }
    IEnumerator LoadingScreenOnFade() { AsyncOperation operation = SceneManager.LoadSceneAsync(levelToLoad); loadingScreen.SetActive(true);
        while (!operation.isDone) { float progress = Mathf.Clamp01(operation.progress / .9f); slider.value = progress; yield return null; } }
    //
    [SerializeField] private InventoryCase _inventoryCase;
    public void Save() { }
    public void Load() {  } }