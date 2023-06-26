using UnityEngine;
public class MovedPeopleTable : MonoBehaviour { public GameObject[] people, arraysSetUnactive;
    public PlayerInventory playerInventory;
    private void OnTriggerEnter2D(Collider2D other) { if (other.CompareTag("Player")) {
        for (int k = 0; k < playerInventory.myInventory.Count; k++) {
            if (playerInventory.myInventory[k].itemName == "SolvedBreakfast") {
                for (int i = 0; i < people.Length; i++) { people[i].SetActive(false); }
                for (int p = 0; p < arraysSetUnactive.Length; p++) { arraysSetUnactive[p].SetActive(false); } } } } }
    public void SetUnactivePeople() { for (int k = 0; k < playerInventory.myInventory.Count; k++) {
        if (playerInventory.myInventory[k].itemName == "SolvedBreakfast") {
            for (int i = 0; i < people.Length; i++) { people[i].SetActive(false); }
            for (int p = 0; p < arraysSetUnactive.Length; p++) { arraysSetUnactive[p].SetActive(false); } } } }
}