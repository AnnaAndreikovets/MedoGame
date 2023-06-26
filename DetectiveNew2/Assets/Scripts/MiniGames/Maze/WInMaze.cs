using UnityEngine;
public class WInMaze : MonoBehaviour { public GameObject[] unactive; public GameObject panelSolved;
    public PlayerInventory playerInventory; private StarMaze starMaze; public AddThing addThing; public CheckFirstDay cfd;
    private void Start () { starMaze = GetComponent<StarMaze>(); }
    private void OnTriggerEnter2D(Collider2D other) { if (starMaze != true) { if (other.CompareTag("Player2")) { addThing.TakeAThinhg2();
        panelSolved.SetActive(true); cfd.Checking(); } } }
}