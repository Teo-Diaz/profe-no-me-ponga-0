using UnityEngine;
using UnityEngine.UI;

public class GraficaDona : MonoBehaviour
{
    public Image[] segmentos;

    public void Actualizar(float[] datos)
    {
        float total = 0f;

        foreach (float v in datos)
            total += v;

        for (int i = 0; i < segmentos.Length; i++)
        {
            float porcentaje = datos[i] / total;
            segmentos[i].fillAmount = porcentaje;
        }
    }
}