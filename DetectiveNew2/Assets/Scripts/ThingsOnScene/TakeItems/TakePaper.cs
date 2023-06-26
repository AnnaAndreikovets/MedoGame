using UnityEngine;
public class TakePaper : MonoBehaviour { public PlayerInventory pi; public MyPickUp myPickUp; public AddThing addThing; public Papers papers;
    public MainTasks mainTasks; int num;
    public void TakeItem() { if (pi.myInventory2.Count <= 4) { myPickUp.TakeAnItem(); addThing.TakeAThinhg(); papers.Replace(); mainTasks.Papers(); } }
}