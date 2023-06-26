using System.Collections.Generic; using UnityEngine; using Ink.Runtime; using System.IO; using System.Collections;
// ��� ���������� � ���������� ��������� ���������� ����������( ������, ������� ����� ���� ������ � ����������� ��� ���������� ������ ��������)
public class DialogueVariables{ // �������, � ������� �� ������������ <������, ������� �������� ������ ����������/ c ��������� ���� ����������>
    public Dictionary<string, Ink.Runtime.Object> variables { get; private set; }
    private Story globalVariablesStory; private const string saveVariablesKey = "INK_VARIABLES";
    // ���������� �����-�� �� �����������
    public DialogueVariables(TextAsset loadGlobalJSON) { globalVariablesStory = new Story(loadGlobalJSON.text);
        if (PlayerPrefs.HasKey(saveVariablesKey)) { string jsonState = PlayerPrefs.GetString(saveVariablesKey);
            globalVariablesStory.state.LoadJson(jsonState); } variables = new Dictionary<string, Ink.Runtime.Object>();
        foreach (string name in globalVariablesStory.variablesState){
            Ink.Runtime.Object value = globalVariablesStory.variablesState.GetVariableWithName(name); variables.Add(name, value); } }
    // ��������� ������ � ������ ���������� ���� � �����  (����� ����������)
    public DialogueVariables(string globalsFilePath) { // ����������� �������
        string inkFileContents = File.ReadAllText(globalsFilePath); // ������ ���������� ����� � ���� ������
        Ink.Compiler compiler = new Ink.Compiler(inkFileContents); // ���������� ���������� ���������� ������ ��� �������������� ���� ������ � ������ �������
        variables = new Dictionary<string, Ink.Runtime.Object>(); // �������������� ������� ��� ����� �������
        // ���������� ������ ��� ���������� ���������� � ����� ���������� ���������� � ���� ��� ������� ����� ��� ������� ����� ����������
        foreach (string name in globalVariablesStory.variablesState)
        {  Ink.Runtime.Object value = globalVariablesStory.variablesState.GetVariableWithName(name); // �������� ������� ��������
            variables.Add(name, value); // ����� ��������� ��� ������ � �������
            Debug.Log("��������������� ���������� ������� �������: " + name + "= " + value); } }
    // ���������� �������� ����������
    public void SaveVariables() { if (globalVariablesStory != null) { VariabelesToStory(globalVariablesStory);
            PlayerPrefs.SetString(saveVariablesKey, globalVariablesStory.state.ToJson()); } }
    // ������� ����������� ����������. ������ ������������� (��������� �������, ������� �� ����� ����������)
    public void StartListening(Story story) { VariabelesToStory(story); // �������� ������� ���������� ������� �� ���� ��� ����� ���������� �����������
        //�������.����������_���������.����������_������_��_�������+=���������_�������;
        story.variablesState.variableChangedEvent += VariableChanged; }
    // ������� ����������� ����������. ���������� ������������� (��������� �������, ������� �� ����� ����������)
    public void StopListening(Story story) { story.variablesState.variableChangedEvent -= VariableChanged; /*������� ������� (��������� �� �������)*/}
    //������� ���������� �� ����������� (��������� name - ��� ����������, � value - �������� ����������)
    private void VariableChanged(string name, Ink.Runtime.Object value) {
        // ��������� ���������� �� ��� � �������, � ����� ������� � ������� ��������� ����� ������
        if (variables.ContainsKey(name)) { variables.Remove(name); variables.Add(name, value); } }
    // ��������� ���������� � ������ ���������� �������
    private void VariabelesToStory(Story story) {  // ���������� �� ������ ������ � �������
        foreach (KeyValuePair<string, Ink.Runtime.Object> variable in variables) { story.variablesState.SetGlobal(variable.Key, variable.Value);  } }
}