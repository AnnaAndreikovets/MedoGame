using UnityEngine; using UnityEngine.UI;
public class BookManager : MonoBehaviour { public TakeAnItemOnce take;  public GameObject imageBook, buttonBook, withoutBookShelf, ParentWithButtons;
    public Image[] images; public Sprite[] sprites; public Animator anim; public AudioSource audioSource;
    public void Checking() { if ((images[0].sprite == sprites[0] || images[0].sprite == sprites[4]) && images[1].sprite == sprites[1] &&
        images[2].sprite == sprites[2] &&  images[3].sprite == sprites[3] && (images[4].sprite == sprites[4] || images[4].sprite == sprites[0]) && 
        (images[5].sprite == sprites[7] || images[5].sprite == sprites[5]) && images[6].sprite == sprites[6] && 
        (images[7].sprite == sprites[5] || images[7].sprite == sprites[7]) && images[8].sprite == sprites[8] ) { withoutBookShelf.SetActive(true);
            ParentWithButtons.SetActive(true); imageBook.SetActive(true); buttonBook.SetActive(true); take.CheckIfTook2(); anim.SetTrigger("isTriggered"); 
        audioSource.Play(); } }
}