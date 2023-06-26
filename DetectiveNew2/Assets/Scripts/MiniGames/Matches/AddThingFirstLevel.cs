using UnityEngine;
public class AddThingFirstLevel : MonoBehaviour { public AddThing addThing; public PlayerInventory pi;
    public void AddFL() { for (int i = 0; i < pi.myInventory.Count; i++) {
        if (pi.myInventory[i].itemName == "FirstLevelBookMatches" || pi.myInventory[i].itemName == "SecondLevelBookMatches" ) 
            { return; } } addThing.TakeAThinhg2(); Debug.Log("Called"); }
}