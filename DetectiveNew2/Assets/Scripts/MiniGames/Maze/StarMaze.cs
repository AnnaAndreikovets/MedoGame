using UnityEngine;
public class StarMaze : MonoBehaviour { public GameObject star; public GameObject needStar;
    public bool activeStar; public GameObject finish; public GameObject light_; public AudioSource audioSource;
    private void OnTriggerEnter2D(Collider2D other) { if (other.CompareTag("Player2")){ star.SetActive(false); needStar.SetActive(false); 
        activeStar = false; finish.SetActive(true); light_.SetActive(false); audioSource.Play(); } }
}
