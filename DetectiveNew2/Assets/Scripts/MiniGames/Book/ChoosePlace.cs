using UnityEngine;
public class ChoosePlace : MonoBehaviour { public int numberOfBook; public BookManager bookManager; Sprite sprite; public int numberForAnim;
    public void ChoosePlaces() { sprite = bookManager.images[numberOfBook].sprite;
        for (int i = numberOfBook; i >= 1; i--) { bookManager.images[i].sprite = bookManager.images[i - 1].sprite; }
        bookManager.images[0].sprite = sprite; }
}