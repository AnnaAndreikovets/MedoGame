using UnityEngine;
public class Matches : MonoBehaviour { public BookMatchesManager bookMatchesManager; public int cell; Collider2D other_;  
    public bool isFull; public int rotation; public Vector3 pos;
    private void OnTriggerEnter2D(Collider2D other) { other_ = other; }
    private void OnTriggerExit2D(Collider2D other) { other_ = null; }
    public void SetPos() { try { if (other_.CompareTag("Thing") && bookMatchesManager.places[cell].isFull == false) {
                pos.x = bookMatchesManager.places[cell].transform.position.x;
                pos.y = bookMatchesManager.places[cell].transform.position.y; bookMatchesManager.places[cell].isFull = true; 
                pos.z = bookMatchesManager.places[cell].transform.position.z; other_.gameObject.transform.position = pos;
                if (rotation == 1 && other_.GetComponent<MoveBookMatches>().rotation == 0) { other_.transform.Rotate(0f, 0f, 90f); }
                else if (rotation == 0 && other_.GetComponent<MoveBookMatches>().rotation == 1) { other_.transform.Rotate(0f, 0f, -90f); } } } catch{} }
    private void Update() { if (other_  && other_.CompareTag("Thing")) { if (other_.GetComponent<DragDrop1>().idle == true)  { SetPos(); } } }
}