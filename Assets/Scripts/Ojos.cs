using UnityEngine;

public class Ojos : MonoBehaviour
{
    public float tamañoOjos = 0.1f;
    void Start()
    {
        ColorAleatorio();
    }
    void Update()
    {
        float animacion = tamañoOjos + Mathf.Sin(Time.time * 4f) * tamañoOjos / 4f;
        transform.localScale = Vector3.one * animacion;
    }
    public void ColorAleatorio()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }

    public void ReiniciarColor()
    {
        GetComponent<Renderer>().material.color = Color.black;
    }
}
