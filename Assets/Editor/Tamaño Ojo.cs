using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Ojos))]
public class TamañoOjo : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();

        Ojos ojos = (Ojos)target;

        ojos.tamañoOjos = EditorGUILayout.Slider("Tamaño", ojos.tamañoOjos, .1f, 2f);

        ojos.transform.localScale = Vector3.one * ojos.tamañoOjos;

        if (GUILayout.Button("Color aleatorio"))
        {
            ojos.ColorAleatorio();
            Debug.Log("Color cambiado con exito");
        }

        if (GUILayout.Button("Reiniciar color"))
        {
            ojos.ReiniciarColor();
            Debug.Log("Color reiniciado con exito");
        }
    }
}
