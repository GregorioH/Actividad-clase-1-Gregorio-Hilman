using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Cara))]
public class ColorCara : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Cara cara = (Cara)target;

        if (GUILayout.Button("Color aleatorio"))
        {
            cara.ColorAleatorio();
            Debug.Log("Color cambiado con exito");
        }

        if (GUILayout.Button("Reiniciar color"))
        {
            cara.ReiniciarColor();
            Debug.Log("Color reiniciado con exito");
        }
    }
}
