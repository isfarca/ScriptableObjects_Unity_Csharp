using UnityEditor;

public class ExampleWindow : EditorWindow
{
    /// <summary>
    /// Create a editor window.
    /// </summary>
    [MenuItem("MyWindow/Example")]
    public static void ShowWindow()
    {
        GetWindow<ExampleWindow>("Example");
    }
}