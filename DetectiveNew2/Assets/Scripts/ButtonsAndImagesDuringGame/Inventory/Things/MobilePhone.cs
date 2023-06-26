using UnityEngine;

public class MobilePhone : MonoBehaviour {
    [SerializeField] private GameObject MobilePhonePanel;
    private void Update() { if (Input.GetKeyDown(KeyCode.Escape)) { if (MobilePhonePanel) { ResumeMP(); } else { ShowMP(); } } }
    public void ShowMP() { MobilePhonePanel.SetActive(true);  Debug.Log("SMP"); }
    public void ResumeMP() { MobilePhonePanel.SetActive(false); Debug.Log("RMP"); }
}
