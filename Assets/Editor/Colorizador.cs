using UnityEditor;
using UnityEngine;

public class Colorizador : EditorWindow
{
    Color color;

    [MenuItem("Window/Colorizador")]
    public static void MostrarVentana()
    {
        GetWindow<Colorizador>("Colorizador");
    }
    void OnGUI()
    {
        GUILayout.Label("Cambia el color del objeto seleccionado", EditorStyles.boldLabel);

        color = EditorGUILayout.ColorField("Color", color);

        if (GUILayout.Button("Colorear"))
        {
            Colorear();
        }
    }

    void Colorear()
    {
        foreach (GameObject objeto in Selection.gameObjects)
        {
            Renderer renderizador = objeto.GetComponent<Renderer>();
            if (renderizador != null)
            {
                renderizador.sharedMaterial.color = color;
            }
        }
    }
}
