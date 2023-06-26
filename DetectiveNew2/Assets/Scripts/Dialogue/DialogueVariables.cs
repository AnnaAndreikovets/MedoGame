using System.Collections.Generic; using UnityEngine; using Ink.Runtime; using System.IO; using System.Collections;
// для сохранения и управления состояния глобальных переменных( объект, который может быть создан и использован для управления другим скриптом)
public class DialogueVariables{ // Словарь, в котором мы сопостовляем <строку, которая является именем переменной/ c значением этой переменной>
    public Dictionary<string, Ink.Runtime.Object> variables { get; private set; }
    private Story globalVariablesStory; private const string saveVariablesKey = "INK_VARIABLES";
    // компилятор какой-то не проверенный
    public DialogueVariables(TextAsset loadGlobalJSON) { globalVariablesStory = new Story(loadGlobalJSON.text);
        if (PlayerPrefs.HasKey(saveVariablesKey)) { string jsonState = PlayerPrefs.GetString(saveVariablesKey);
            globalVariablesStory.state.LoadJson(jsonState); } variables = new Dictionary<string, Ink.Runtime.Object>();
        foreach (string name in globalVariablesStory.variablesState){
            Ink.Runtime.Object value = globalVariablesStory.variablesState.GetVariableWithName(name); variables.Add(name, value); } }
    // принимает строку с именем глобальный путь к файлу  (новый компилятор)
    public DialogueVariables(string globalsFilePath) { // компилируем историю
        string inkFileContents = File.ReadAllText(globalsFilePath); // читает содержимое файли в виде строки
        Ink.Compiler compiler = new Ink.Compiler(inkFileContents); // используем встроенный компилятор чернил для преоброзования этой строки в объект истории
        variables = new Dictionary<string, Ink.Runtime.Object>(); // инициализируем словарь как новый словарь
        // перебираем каждое имя глобальной переменной в файле глобальных переменных с этим для каждого цикла для каждого имени переменной
        foreach (string name in globalVariablesStory.variablesState)
        {  Ink.Runtime.Object value = globalVariablesStory.variablesState.GetVariableWithName(name); // получаем текущее значение
            variables.Add(name, value); // затем добавляем эту запись в словарь
            Debug.Log("Инициализирован глобальный вариант диалога: " + name + "= " + value); } }
    // сохранение значения переменных
    public void SaveVariables() { if (globalVariablesStory != null) { VariabelesToStory(globalVariablesStory);
            PlayerPrefs.SetString(saveVariablesKey, globalVariablesStory.state.ToJson()); } }
    // функция подключения переменной. Начать прослушивание (принимает историю, которую мы хотим прослушать)
    public void StartListening(Story story) { VariabelesToStory(story); // вызываем перебор переменных истории до того как будет устоновлен наблюдатель
        //история.переменная_состояния.переменной_строки_из_истории+=изменённое_событие;
        story.variablesState.variableChangedEvent += VariableChanged; }
    // функция подключения переменной. Остановить прослушивание (принимает историю, которую мы хотим прослушать)
    public void StopListening(Story story) { story.variablesState.variableChangedEvent -= VariableChanged; /*удаляем функцию (слушателя из истории)*/}
    //функция наблюдения за переменными (принимает name - имя переменной, а value - значение переменной)
    private void VariableChanged(string name, Ink.Runtime.Object value) {
        // проверяем содержится ли имя в словаре, а затем удаляем и сразуже загружием новые данные
        if (variables.ContainsKey(name)) { variables.Remove(name); variables.Add(name, value); } }
    // загружаем переменные в каждую чернильную историю
    private void VariabelesToStory(Story story) {  // проходимся по каждой записи в словаре
        foreach (KeyValuePair<string, Ink.Runtime.Object> variable in variables) { story.variablesState.SetGlobal(variable.Key, variable.Value);  } }
}