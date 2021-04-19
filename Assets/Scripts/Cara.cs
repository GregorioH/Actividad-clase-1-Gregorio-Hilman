using UnityEngine;

public class Cara : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ColorAleatorio();
    }

    // Update is called once per frame
    public void ColorAleatorio()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }

    public void ReiniciarColor()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
