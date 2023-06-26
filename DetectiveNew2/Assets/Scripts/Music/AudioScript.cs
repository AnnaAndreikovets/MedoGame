using UnityEngine; using UnityEngine.SceneManagement;
public class AudioScript : MonoBehaviour { private static AudioScript instance; public AudioSource audioSource;
    public PlayerInventory pi; public GameObject AudioManagerLoaded;
    void Start() => CheckingScene(); 
    public void CheckingScene() {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(18) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(23) ) {
            if(pi.ValueOfSound[4].itemName == "2") Destroy(gameObject); else { AudioManagerLoaded = GameObject.Find("AudioManager");
                if (AudioManagerLoaded != null) Destroy(AudioManagerLoaded); pi.ValueOfSound[4].itemName = "2"; instance = this; 
                DontDestroyOnLoad(transform.gameObject); } }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(0) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(38) ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(36)|| SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(10) ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(12) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(25) || 
            SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(25) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(39) ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(41) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(35))
        { pi.ValueOfSound[4].itemName = "1"; AudioManagerLoaded = GameObject.Find("AudioManager2"); if (AudioManagerLoaded != null) 
                Destroy(AudioManagerLoaded); AudioManagerLoaded = GameObject.Find("AudioManager"); if (AudioManagerLoaded != null) Destroy(AudioManagerLoaded); }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(2) ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(4) ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(5) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(6) ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(7) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(8) ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(9) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(11) ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(13) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(14) ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(15) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(16) ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(17) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(19) ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(20) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(21) ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(22) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(24) ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(26) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(27) ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(28) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(29) ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(30) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(31) ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(32) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(33) ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(34) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(40) ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(6) || SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(37))
        { if (pi.ValueOfSound[4].itemName == "0") Destroy(gameObject); else { AudioManagerLoaded = GameObject.Find("AudioManager2");
                if (AudioManagerLoaded != null) Destroy(AudioManagerLoaded); 
                pi.ValueOfSound[4].itemName = "0"; instance = this;  DontDestroyOnLoad(transform.gameObject); } } }
}