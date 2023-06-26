using UnityEngine; using UnityEngine.UI;
public class MoveCellSafe : MonoBehaviour { public Image[] images; public TakeAnItemOnce addThing; public int[] number;
    public Sprite[] sprites;  public GameObject panelSolved;
    public void MoveCellDown0() {  SetRightNumber(0, "Less"); }
    public void MoveCellDown1() {  SetRightNumber(1, "Less"); }
    public void MoveCellDown2() { SetRightNumber(2, "Less"); }
    public void MoveCellDown3() { SetRightNumber(3, "Less"); }
    public void MoveCellUp0() { SetRightNumber(0, "More"); }
    public void MoveCellUp1() { SetRightNumber(1, "More"); }
    public void MoveCellUp2() { SetRightNumber(2, "More"); }
    public void MoveCellUp3() { SetRightNumber(3, "More"); }
    public void SetRightNumber( int num, string moreOrLess) { 
        if (moreOrLess == "More" && number[num] == 0) { images[num].sprite = sprites[1]; number[num] = 1; }
        else if (moreOrLess == "More" && number[num] == 1) { images[num].sprite = sprites[2]; number[num] = 2; }
        else if (moreOrLess == "More" && number[num] == 2) { images[num].sprite = sprites[3]; number[num] = 3; }
        else if (moreOrLess == "More" && number[num] == 3) { images[num].sprite = sprites[4]; number[num] = 4; }
        else if (moreOrLess == "More" && number[num] == 4) { images[num].sprite = sprites[5]; number[num] = 5; }
        else if (moreOrLess == "More" && number[num] == 5) { images[num].sprite = sprites[6]; number[num] = 6; }
        else if (moreOrLess == "More" && number[num] == 6) { images[num].sprite = sprites[7]; number[num] = 7; }
        else if (moreOrLess == "More" && number[num] == 7) { images[num].sprite = sprites[8]; number[num] = 8; }
        else if (moreOrLess == "More" && number[num] == 8) { images[num].sprite = sprites[9]; number[num] = 9; }
        else if (moreOrLess == "More" && number[num] == 9) { images[num].sprite = sprites[0]; number[num] = 0; }
        else if (moreOrLess == "Less" && number[num] == 0) { images[num].sprite = sprites[9]; number[num] = 9; }
        else if (moreOrLess == "Less" && number[num] == 1) { images[num].sprite = sprites[0]; number[num] = 0; }
        else if (moreOrLess == "Less" && number[num] == 2) { images[num].sprite = sprites[1]; number[num] = 1; }
        else if (moreOrLess == "Less" && number[num] == 3) { images[num].sprite = sprites[2]; number[num] = 2; }
        else if (moreOrLess == "Less" && number[num] == 4) { images[num].sprite = sprites[3]; number[num] = 3; }
        else if (moreOrLess == "Less" && number[num] == 5) { images[num].sprite = sprites[4]; number[num] = 4; }
        else if (moreOrLess == "Less" && number[num] == 6) { images[num].sprite = sprites[5]; number[num] = 5; }
        else if (moreOrLess == "Less" && number[num] == 7) { images[num].sprite = sprites[6]; number[num] = 6; }
        else if (moreOrLess == "Less" && number[num] == 8) { images[num].sprite = sprites[7]; number[num] = 7; }
        else if (moreOrLess == "Less" && number[num] == 9) { images[num].sprite = sprites[8]; number[num] = 8; }
        CheckRightResult(); }
    public void CheckRightResult() { if (number[0] == 2 && number[1] == 9 && number[2] == 5 && number[3] == 3) {
            addThing.CheckIfTook2(); panelSolved.SetActive(true); } } 
}