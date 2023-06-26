using UnityEngine; using UnityEngine.SceneManagement; 
public class BookMatchesManager : MonoBehaviour { public Matches[] places, places2; public MyItem thisItem;
    public MoveBookMatches[] bookMatches, bookMatches2; public DeleteThing deleteThing1, deleteThing2;
    public PlayerInventory pi; public GameObject panelSolved; public AddThing addThing1, addThing2; public int i, t;
    public void FirstLevel() { for (i = 0; i < bookMatches.Length; i++) { if (bookMatches[10].clickOnTheButton == true) { goto Path2; }
            else if (bookMatches[i].clickOnTheButton == true) { if (bookMatches[i].GetComponent<DragDrop1>().idle == true) { SceneManager.LoadSceneAsync(24);
                    return; } } } return;
    Path2: if (places[9].isFull == true) { addThing1.TakeAThinhg2(); deleteThing1.DeleteThing_(); SceneManager.LoadSceneAsync(24); }
        if (bookMatches[10].GetComponent<DragDrop1>().idle == true && places[9].isFull != true) { SceneManager.LoadSceneAsync(24);
            Debug.Log("ChangedScene1");
        } }
    public void SecondLevel() { for (i = 0; i < bookMatches2.Length; i++) { if (bookMatches2[17].clickOnTheButton == true) { goto Path2; }
            else if (bookMatches2[i].clickOnTheButton == true) { if (bookMatches2[i].GetComponent<DragDrop1>().idle == true
                 && i != 17) { SceneManager.LoadSceneAsync(24); return; } } } return; Path2:
        if (places[21].isFull == true || places2[21].isFull == true) { addThing2.TakeAThinhg2(); deleteThing2.DeleteThing_(); pi.myInventory2.Add(thisItem); 
            panelSolved.SetActive(true); return; }
        else if (bookMatches2[17].GetComponent<DragDrop1>().idle == true && (places[21].isFull == false  ) ) {
            SceneManager.LoadSceneAsync(24); Debug.Log("ChangedScene2"); } }
    private void Update() { for (int p = 0; p < pi.myInventory.Count; p++) { if (pi.myInventory[p].itemName == "FirstLevelBookMatches") { FirstLevel(); }
        else if (pi.myInventory[p].itemName == "SecondLevelBookMatches") { SecondLevel(); }
            else if (pi.myInventory[p].itemName == "MatchBox") { panelSolved.SetActive(true);             } } }
}