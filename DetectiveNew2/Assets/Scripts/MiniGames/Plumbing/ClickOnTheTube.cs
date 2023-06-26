using UnityEngine;
public class ClickOnTheTube : MonoBehaviour { public int num = 5;  public Animator anim;
    public void ClickTubeRotate4() { if (num == 0) { num = 1; anim.SetTrigger("Rotate1"); }
        else if (num == 1) { num = 2; anim.SetTrigger("Rotate2"); }
        else if (num == 2) { num = 3; anim.SetTrigger("Rotate3"); }
        else if (num == 3) { num = 0; anim.SetTrigger("Rotate0"); }}
    public void ClickTubeRotate2() { if (num == 0) { num = 1; anim.SetTrigger("Rotate0"); }
        else if (num == 1) { num = 0; anim.SetTrigger("Rotate1"); } }
}