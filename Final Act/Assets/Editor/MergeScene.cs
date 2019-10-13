using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/*
 The script is used for combining two scenes together.
 Took it from:
 https://answers.unity.com/questions/235019/merge-scene-in-the-editor.html
 */

public class MergeScene : MonoBehaviour
{


    [MenuItem("Example/Load Scene Additive")]
    static void Apply()
    {
        string strScenePath = AssetDatabase.GetAssetPath(Selection.activeObject);
        if (strScenePath == null || !strScenePath.Contains(".unity"))
        {
            EditorUtility.DisplayDialog("Select Scene", "You Must Select a Scene!", "Ok");
            EditorApplication.Beep();
            return;
        }
        Debug.Log("Opening " + strScenePath + " additively");
        EditorApplication.OpenSceneAdditive(strScenePath);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
