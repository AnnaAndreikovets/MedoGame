using UnityEngine; using UnityEngine.UI;
public class Photos : MonoBehaviour { public Image Photo; public Sprite[] ImagesOfPhoto; public Text textOfDescription; public int num;
    public string[] descriptions; public GameObject arrowLeft, arrowRight; public TakeAnItemOnce takeAnItemOnce;
    public void ClickOnTheArrowRight() { if (num == 8) { arrowRight.SetActive(false); } if (num == 9) { num--; takeAnItemOnce.CheckIfTook2(); } 
        num++; SetImageAndDescription(); arrowLeft.SetActive(true); }
    public void ClickOnTheArrowLeft() { if (num == 1) { arrowLeft.SetActive(false); } if (num == 0) { num++; } num--; 
        SetImageAndDescription(); arrowRight.SetActive(true); }
    public void SetImageAndDescription() { Photo.sprite = ImagesOfPhoto[num]; textOfDescription.text = descriptions[num]; }
}