using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Boca))]
public class TamañoOjos : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();

        Boca boca = (Boca)target;

        boca.tamañoBoca = EditorGUILayout.Slider("Tamaño", boca.tamañoBoca, .1f, 2f);

        boca.transform.localScale = Vector3.one * boca.tamañoBoca;

        if (GUILayout.Button("Color aleatorio"))
        {
            boca.ColorAleatorio();
            Debug.Log("Color cambiado con exito");
        }

        if (GUILayout.Button("Reiniciar color"))
        {
            boca.ReiniciarColor();
            Debug.Log("Color reiniciado con exito");
        }
    }
}
