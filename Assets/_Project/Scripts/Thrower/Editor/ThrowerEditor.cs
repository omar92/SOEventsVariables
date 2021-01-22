using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Thrower))]
[CanEditMultipleObjects]
public class ThrowerEditor : Editor
{
    Thrower script;
    private void OnEnable()
    {
        script = (Thrower)target;

    }
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (Application.isPlaying)
        {
            if (GUILayout.Button("Throw"))
            {
                script.Throw();
            }
            if (GUILayout.Button("Reload"))
            {
                script.Reload();
            }
        }
    }

}
