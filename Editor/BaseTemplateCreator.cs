#if UNITY_EDITOR
using System.IO;
using UnityEditor;
using UnityEngine;

public class BaseTemplateCreator : MonoBehaviour
{
    static string TEMPLATE_BASE_PATH =  @"Packages/com.partisanprogrammer.base-templates/Editor/Templates/";
    const string ASSET_PATH = "Assets/Create/Templates/Base/";

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
    
    [MenuItem(ASSET_PATH + "Editor", priority = 30)]
    public static void CreateEditorScriptMenuItem()
    {
        var filename = "EditorScriptTemplate.txt";
        CreateScriptAssetFromTemplateFile(filename);
    }
    
    [MenuItem(ASSET_PATH + "Interface", priority = 30)]
    public static void CreateInterfaceMenuItem()
    {
        var filename = "InterfaceTemplate.txt";
        CreateScriptAssetFromTemplateFile(filename);
    }
    
    [MenuItem(ASSET_PATH + "Enum", priority = 30)]
    public static void CreateEnumMenuItem()
    {
        var filename = "EnumTemplate.txt";
        CreateScriptAssetFromTemplateFile(filename);
    }
    
    [MenuItem(ASSET_PATH + "Attribute", priority = 30)]
    public static void CreateAttributeMenuItem()
    {
        var filename = "AttributeTemplate.txt";
        CreateScriptAssetFromTemplateFile(filename);
    }
    
    [MenuItem(ASSET_PATH + "Singleton", priority = 30)]
    public static void CreateSingletonMenuItem()
    {
        var filename = "SingletonTemplate.txt";
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