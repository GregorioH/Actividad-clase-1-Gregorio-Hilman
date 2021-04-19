using UnityEngine;

public class Boca : MonoBehaviour
{
    public float tamañoBoca = 0.1f;

    void Start()
    {
        ColorAleatorio();
    }
    void Update()
    {
        float animacion = tamañoBoca + Mathf.Sin(Time.time * 4f) * tamañoBoca / 4f;
        transform.localScale = Vector3.one * animacion;
    }
    public void ColorAleatorio()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }

    public void ReiniciarColor()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}