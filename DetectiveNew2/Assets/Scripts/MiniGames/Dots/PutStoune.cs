using UnityEngine;
public class PutStoune : MonoBehaviour { public DotsManager dotsManager; public int num, X, Y;
    public void Click() { if (dotsManager.CountOfDots != 0 && dotsManager.ClickOnTheCell[num] == false)
        { dotsManager.ClickOnTheCell[num] = true; dotsManager.CountOfDots--; 
            dotsManager.StounesImagesOnScene[num].sprite = dotsManager.stounesSprites[Random.Range(0, 5)];
            dotsManager.stounesHorizontal[X] = dotsManager.stounesHorizontal[X] + 1;
            dotsManager.stounesVertical[Y] = dotsManager.stounesVertical[Y] + 1; }
        else if (dotsManager.ClickOnTheCell[num] == true) { dotsManager.ClickOnTheCell[num] = false; dotsManager.CountOfDots++;
            dotsManager.StounesImagesOnScene[num].sprite = dotsManager.stounesSprites[5];
            dotsManager.stounesHorizontal[X] = dotsManager.stounesHorizontal[X] - 1;
            dotsManager.stounesVertical[Y] = dotsManager.stounesVertical[Y] - 1; }
        string textNum = "" + dotsManager.CountOfDots;
        dotsManager.textOfCount.text = textNum; dotsManager.Checking(); }
}