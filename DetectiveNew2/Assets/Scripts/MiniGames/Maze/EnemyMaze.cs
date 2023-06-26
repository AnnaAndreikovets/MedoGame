using UnityEngine;
public class EnemyMaze : MonoBehaviour { public MazePlayer mazePlayer; public AudioSource audioSource; float time_ = 0.3f; int num = 0;
    private void OnTriggerEnter2D(Collider2D other) { if (other.CompareTag("Player2")) { audioSource.Play(); num = 1; } }
    private void Update() { if(num == 1) time_ -= Time.deltaTime; if (time_ <= 0 ) { mazePlayer.ResetPos(); } }
}