using UnityEngine; using UnityEngine.UI; using System;

public class PushTheButton : MonoBehaviour {
    public static event Action<string> ButtonPressed = delegate { }; private int deviderPosition; private string buttonName, buttonValue;
    private void Start() { buttonName = gameObject.name; deviderPosition = buttonName.IndexOf("_");
        buttonValue = buttonName.Substring(0, deviderPosition); gameObject.GetComponent<Button>().onClick.AddListener(ButtonClicked); }
    private void ButtonClicked() => ButtonPressed(buttonValue);
}
