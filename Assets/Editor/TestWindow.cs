
using UnityEditor;


public class TestWindow : EditorWindow
{
    private const string MENU_PATH = "Test/Table";

    [MenuItem(MENU_PATH)]
    private static void OpenMenu()
    {
        var window = GetWindow<TestWindow>();
        window.Show();
    }
}
