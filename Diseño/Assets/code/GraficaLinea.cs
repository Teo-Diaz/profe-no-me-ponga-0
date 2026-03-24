using UnityEngine;

public class GraficaLinea : MonoBehaviour
{
    public LineRenderer lineRenderer;

    public void Actualizar(float[] datos)
    {
        lineRenderer.positionCount = datos.Length;

        for (int i = 0; i < datos.Length; i++)
        {
            lineRenderer.SetPosition(i, new Vector3(i * 1.5f, datos[i], 0));
        }
    }
}