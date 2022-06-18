using UnityEditor;
using UnityEngine;

public class EditorExtentionMenuItemTest : MonoBehaviour
{
    [MenuItem("自作メニュー/MenuItemは/意外と/多機能")]
    private static void Meaning() { }

    [MenuItem("自作メニュー/Shortcut #&g+")]
    private static void Shortcut() { }

    [MenuItem("自作メニュー/CheckMark")]
    private static void CheckMark() {
        string menuPath = "自作メニュー/CheckMark";
        bool isChecked = Menu.GetChecked(menuPath);
        Menu.SetChecked(menuPath, !isChecked);
    }

    [MenuItem("自作メニュー/Validate")]
    private static void Validate() { }

    [MenuItem("自作メニュー/Validate", validate = true)]
    private static bool ValidateValidation() {
        return Application.isPlaying;
    }

    [MenuItem("自作メニュー/Priority1", priority = 1)]
    private static void Priority1() { }

    [MenuItem("自作メニュー/Priority100", priority = 100)]
    private static void Priority100() { }
    
    /// <summary>
    /// ログを表示する
    /// </summary>
    [MenuItem("Tools/ShowLog")]
    private static void ShowLog() {
        Debug.Log("ログ");
    }
    [MenuItem("宝箱/取る/本当に？/絶対？/どうしても？")]
    private static void AAA() {}

    [MenuItem("宝箱/取らない")]
    private static void BBB() {}
}
