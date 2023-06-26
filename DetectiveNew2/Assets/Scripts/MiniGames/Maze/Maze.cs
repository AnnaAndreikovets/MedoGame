using UnityEngine;
public class Maze : MonoBehaviour { public GameObject maze; public GameObject player; public GameObject[] HitBoxes;

    public void Open() { maze.SetActive(true); player.SetActive(false);
        for (int i = 0; i < HitBoxes.Length; i++) { HitBoxes[i].SetActive(false); } }
    public void Resume() { maze.SetActive(false);
        for (int i = 0; i < HitBoxes.Length; i++) { HitBoxes[i].SetActive(true); }
        player.SetActive(true); }
}