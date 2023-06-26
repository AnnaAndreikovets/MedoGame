using UnityEngine; using UnityEngine.UI;
public class DotsManager : MonoBehaviour { public int CountOfDots; public bool[] ClickOnTheCell; public Sprite[] stounesSprites;
    public Image[] StounesImagesOnScene; public AddThing addThing; public TakeStar takeStar; public Text textOfCount;
    public GameObject buttons; public Animator anim; public int[] stounesHorizontal, stounesVertical;
    public void Checking() {
        if (stounesHorizontal[0] == 1 && stounesHorizontal[1] == 2 && stounesHorizontal[2] == 1 &&
        stounesHorizontal[3] == 1 && stounesHorizontal[4] == 1 && stounesHorizontal[5] == 1 && stounesHorizontal[6] == 2 && 
        stounesHorizontal[7] == 3 && stounesHorizontal[8] == 1 &&
        stounesVertical[0] == 3 && stounesVertical[1] == 3 && stounesVertical[2] == 3 && stounesVertical[3] == 2 && stounesVertical[4] == 2) {
            addThing.TakeAThinhg2(); takeStar.TakeAStar(); buttons.SetActive(false); anim.SetTrigger("isTriggered"); } } 
}