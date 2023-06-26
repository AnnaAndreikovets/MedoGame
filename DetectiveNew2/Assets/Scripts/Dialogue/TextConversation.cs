using System.Collections;using UnityEngine.UI; using UnityEngine;
public class TextConversation : MonoBehaviour { public Text dialogueText; private string text;
    private void Start() { text = dialogueText.text; dialogueText.text = ""; StartCoroutine(TextCoroutine()); }
    IEnumerator TextCoroutine() { foreach (char abc in text) { dialogueText.text += abc; yield return new WaitForSeconds(0.04f); } }
}