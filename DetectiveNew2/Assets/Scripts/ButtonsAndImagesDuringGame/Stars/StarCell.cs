using UnityEngine; using UnityEngine.UI;
public class StarCell : MonoBehaviour {[SerializeField] private Image itemImage; public Star thisStar;
    private StarsManager inventory;
    private void Start() { inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<StarsManager>(); }
    public void Setup(Star newStar)
    { thisStar = newStar; if (thisStar) { itemImage.sprite = thisStar.itemImage; } }
}