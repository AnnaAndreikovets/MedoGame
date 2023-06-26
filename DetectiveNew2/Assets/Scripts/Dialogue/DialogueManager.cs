using UnityEngine.UI; using UnityEngine; using Ink.Runtime; using System.Collections.Generic; using Ink.UnityIntegration;
using UnityEngine.EventSystems; using System.Collections; using UnityEngine.SceneManagement;
public class DialogueManager : MonoBehaviour { private static DialogueManager instance;
    [SerializeField] private GameObject dialoguePanel, bgPanel, arrow, portraitImageDefault, portraitImagePerson1,
        portraitImagePerson2;[SerializeField] Text dialogueText, displayNameText;
    [SerializeField] GameObject[] choices, portraitImages; private Text[] choicesText; public Story currentStory;
    private const string SPEAKER_TAG = "speaker"; private const string PORTRAIT_TAG = "portrait";
    public bool dialogueIsPlaying { get; private set; }
    private DialogueVariables dialogueVariables; // частный объект диалоговых переменных
    [SerializeField] private InkFile globalsInkFile; // глобальная переменная файла чернил
    [SerializeField] private TextAsset loadGlobalsJSON;
    private void Awake() { if (instance != null) { Debug.Log("Found more than one Dialogue Manager in the Scene"); } instance = this; 
        // переменные диалога будут равны новому объекту переменных диалога(принимает путь к точечному файлу глобального файла чернил обратно в Unity)
        // говоря по-другому: принимает чернильную штуку под именем load_globals.ink
        dialogueVariables = new DialogueVariables(loadGlobalsJSON);  }
    public static DialogueManager GetInstance() { return instance; }
    private void Start() { dialogueIsPlaying = false; if(dialoguePanel)dialoguePanel.SetActive(false); if(bgPanel)bgPanel.SetActive(false);
        choicesText = new Text[choices.Length]; int index = 0;
        foreach (GameObject choice in choices) { choicesText[index] = choice.GetComponentInChildren<Text>(); index++; } }
    private void Update() { if (!dialogueIsPlaying) { return; } }
    public void EnterDialogueMode(TextAsset inkJSON) { currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true; dialoguePanel.SetActive(true); bgPanel.SetActive(true);
        // метод начала прослушивания (принимает историю)
        dialogueVariables.StartListening(currentStory);
        if (currentStory.canContinue) { dialogueText.text = currentStory.Continue(); }// Continue даёт нам следующую строку из истории 
        else { ExitDialogueMode(); displayNameText.text = "???"; portraitImageDefault.SetActive(true);
            portraitImagePerson1.SetActive(false); portraitImagePerson2.SetActive(false); } dialogueVariables.SaveVariables(); }
    private void ExitDialogueMode() { dialogueIsPlaying = false; dialoguePanel.SetActive(false);
        bgPanel.SetActive(false); dialogueText.text = ""; Time.timeScale = 1f;
        // метод остановки прослушивания (принимает историю) удаляет слушателя из истории 
        dialogueVariables.SaveVariables(); dialogueVariables.StopListening(currentStory); }
    public void ContinueStory() { if (currentStory.canContinue) { dialogueText.text = currentStory.Continue();
            DisplayChoices(); HandleTags(currentStory.currentTags); } else { ExitDialogueMode(); } }
    public void SetTagsStart() { HandleTags(currentStory.currentTags); }
    private void HandleTags(List<string> currentTags) { foreach (string tag in currentTags) { string[] splitTag = tag.Split(':'); if (splitTag.Length != 2) {
        Debug.LogError("Tag could not be appropriately parsed: " + tag); } string tagKey = splitTag[0].Trim(); // под нулем у нас имя тэга
        string tagValue = splitTag[1].Trim(); // под еденицей у нас значение, которое нужно для изменения
        switch (tagKey) { case SPEAKER_TAG: displayNameText.text = tagValue; break;
            case PORTRAIT_TAG: if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(7) ||
                SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(14))
                    { for (int i = 0; i < portraitImages.Length; i++) { portraitImages[i].SetActive(false); } if (tagValue == "1") { portraitImages[1].SetActive(true); }
                    else if (tagValue == "2") { portraitImages[2].SetActive(true); } else if (tagValue == "3") { portraitImages[3].SetActive(true); }
                    else if (tagValue == "4") { portraitImages[4].SetActive(true); } else if (tagValue == "5") { portraitImages[5].SetActive(true); }
                    else if (tagValue == "6") { portraitImages[6].SetActive(true); } else if (tagValue == "7") { portraitImages[7].SetActive(true); }
                    else if (tagValue == "8") { portraitImages[8].SetActive(true); } else { portraitImages[0].SetActive(true); } }
                    else { if (tagValue == "1") { portraitImagePerson1.SetActive(true); portraitImagePerson2.SetActive(false); }
                        else if (tagValue == "2") { portraitImagePerson1.SetActive(false); portraitImagePerson2.SetActive(true); }
                        else { portraitImageDefault.SetActive(true); portraitImagePerson1.SetActive(false);
                            portraitImagePerson2.SetActive(false); } } break;
                default: Debug.Log("Tag came in but is not currently being handled: " + tag); break; } } }
    public void DisplayChoices() { try { List<Choice> currentChoices = currentStory.currentChoices;
            /*if (currentChoices.Count > choices.Length) { Debug.LogError("More choices were given than the UI can" +
                "support. Number of choices given: " + currentChoices.Count); }*/ int index = 0;
            foreach (Choice choice in currentChoices) { choices[index].gameObject.SetActive(true);
                choicesText[index].text = choice.text; index++; } for (int i = index; i < choices.Length; i++) {
                choices[i].gameObject.SetActive(false); } StartCoroutine(SelectFirstChoice());
            if (currentChoices.Count == 0) { arrow.SetActive(true); } else { arrow.SetActive(false); } } catch {} }
    private IEnumerator SelectFirstChoice() { EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame(); EventSystem.current.SetSelectedGameObject(choices[0].gameObject); }
    public void MakeChoices(int choiceIndex) { currentStory.ChooseChoiceIndex(choiceIndex);}
    public Ink.Runtime.Object GetVariableState(string variableName) { // принимает строку переменной
        // ссылаемся на словарь. Если переменная существует, то он вернёт её, а иначе будет вывод в консоль
        Ink.Runtime.Object variableValue = null;
        dialogueVariables.variables.TryGetValue(variableName, out variableValue);
        if (variableValue == null) { Debug.LogError("Ink variable was found to be null: " + variableName); }
        return variableValue; }
    public void OnApplicationQuit() { dialogueVariables.SaveVariables(); }
} 