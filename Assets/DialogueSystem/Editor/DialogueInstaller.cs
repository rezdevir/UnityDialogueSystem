#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

[InitializeOnLoad]
public static class DialogueSystemInstaller
{
    // static DialogueSystemInstaller()
    // {
       
    //     const string packageUrl = "https://github.com/rezdevir/com.rezdev.dialoguesystem.git";

    //     EditorApplication.update += Install;
    // }

    // private static AddRequest request;

    // private static void Install()
    // {
    //     EditorApplication.update -= Install;

    //     request = Client.Add("https://github.com/rezdevir/com.rezdev.dialoguesystem.git");

    //     EditorApplication.update += Progress;
    // }

    // private static void Progress()
    // {
    //     if (!request.IsCompleted)
    //         return;

    //     EditorApplication.update -= Progress;

    //     if (request.Status == StatusCode.Success)
    //         Debug.Log($"[RezDev DialogueSystem] Installed successfully: {request.Result.name}");
    //     else if (request.Status >= StatusCode.Failure)
    //         Debug.LogError($"[RezDev DialogueSystem] Installation failed: {request.Error.message}");
    // }
}
#endif
