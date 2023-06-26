using UnityEngine;
public class BellSound : MonoBehaviour { [SerializeField] private AudioClip[] buttonSound; private AudioSource audioSource;
    private void Start() { audioSource = GetComponent<AudioSource>(); }
    public void PlaySoundBell() { audioSource.PlayOneShot(buttonSound[Random.Range(0, 3)]); }
}