using UnityEngine;
public class Murder : MonoBehaviour { int numberAction1, numberAction2, numberAction3, numberAction4, numberAction5,
        numberAction6, numberAction7, numberAction8, nine; public GameObject arrowExit, visualCue;
    public void First() { numberAction1++; }
    public void Second() { numberAction2++; }
    public void Third() { numberAction3++; }
    public void Four() { numberAction4++; }
    public void Five() { numberAction5++; }
    public void Six() { numberAction6++; }
    public void Seven() { numberAction7++; }
    public void EightMaks() { numberAction8++; }
    public void Nine() { nine++; }
    private void Leave() {  if (numberAction1 >= 1 && numberAction2 >= 1 && numberAction3 >= 1 && numberAction4 >= 1
        && numberAction5 >= 1 && numberAction6 >= 1 && numberAction7 >= 1 && nine >= 1) { visualCue.SetActive(true); }
    if (numberAction1 >= 1 && numberAction2 >= 1 && numberAction3 >= 1 && numberAction4 >= 1
                && numberAction5 >= 1 && numberAction6 >= 1 && numberAction7 >= 1 && numberAction8 >= 1)
        { arrowExit.SetActive(true); } }
    private void Update() { Leave(); }
}