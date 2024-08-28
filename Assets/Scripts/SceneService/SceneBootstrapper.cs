using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

[InitializeOnLoad]
public class SceneBootstrapper
{
    private const string previousScene = "";

    private static string BootstrapScene => EditorBuildSettings.scenes[0].path;

    private static string PreviousScene
    {
        get => EditorPrefs.GetString(previousScene);
        set => EditorPrefs.SetString(previousScene, value);
    }

    private static bool isBootstrapperEnabled = true;

    // A static constructor runs with InitializeOnLoad attribute
    static SceneBootstrapper()
    {
        // Listen for the Editor changing play states
        EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
    }

    // This runs when the Editor changes play state (e.g. entering Play mode, exiting Play mode)
    private static void OnPlayModeStateChanged(PlayModeStateChange playModeStateChange)
    {
        if (!isBootstrapperEnabled)
        {
            return;
        }

        switch (playModeStateChange)
        {
            // This loads bootstrap scene when entering Play mode
            case PlayModeStateChange.ExitingEditMode:

                PreviousScene = EditorSceneManager.GetActiveScene().path;

                if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo() && IsSceneInBuildSettings(BootstrapScene))
                {
                    EditorSceneManager.OpenScene(BootstrapScene);
                }
                break;

            // This restores the PreviousScene when exiting Play mode
            case PlayModeStateChange.EnteredEditMode:

                if (!string.IsNullOrEmpty(PreviousScene))
                {
                    EditorSceneManager.OpenScene(PreviousScene);
                }
                break;
        }
    }

    private static bool IsSceneInBuildSettings(string scenePath)
    {
        if (string.IsNullOrEmpty(scenePath))
            return false;

        foreach (var scene in EditorBuildSettings.scenes)
        {
            if (scene.path == scenePath)
            {
                return true;
            }
        }

        return false;
    }
}