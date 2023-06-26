using UnityEngine.SceneManagement; using UnityEngine;

public class ToScene : MonoBehaviour {
    private PlayerController playerController; public VectorValue pos_;
    private void Start() { playerController = GetComponent<PlayerController>();}
    public void LoadHouseFirstDay() { playerController.pos = pos_; SceneManager.LoadSceneAsync(3); }
    public void LoadRoom2() => SceneManager.LoadSceneAsync(5);
}
