#if UNITY_EDITOR
using System.IO;
using UnityEditor;
using UnityEngine;

public class BaseTemplateCreator : MonoBehaviour
{
    static string TEMPLATE_BASE_PATH =  @"Packages/com.partisanprogrammer.base-templates/Editor/Templates/";
    const string ASSET_PATH = "Assets/Create/Templates/";

    [MenuItem(ASSET_PATH + "Scriptable Object", priority = 30)]
    public static void CreateMessageMenuItem()
    {
        var filename = "ScriptableObjectTemplate.txt";
        CreateScriptAssetFromTemplateFile(filename);
    }
    
    [MenuItem(ASSET_PATH + "MonoBehaviour", priority = 30)]
    public static void CreateMonoBehaviourMenuItem()
    {
        var filename = "MonoBehaviourTemplate.txt";
        CreateScriptAssetFromTemplateFile(filename);
    }
    public static void CreateScriptAssetFromTemplateFile(string templateName)
    {
        var createdFileName = templateName.Insert(0, "New")
            .Replace("Template.txt", ".cs");
        var fullTemplateFilePath = Path.Join (TEMPLATE_BASE_PATH, templateName);
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(fullTemplateFilePath, createdFileName);
    }
}
#endif