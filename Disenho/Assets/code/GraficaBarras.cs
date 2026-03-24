using UnityEngine;
using UnityEngine.UI;

public class GraficaBarras : MonoBehaviour
{
    [Header("Referencias")]
    public RectTransform[] barras; // 4 barras
    public Image[] imagenes;       // mismas barras pero como Image

    [Header("Configuración")]
    public float alturaMax = 200f;
    public float valorMax = 50f;
    public float velocidadAnimacion = 5f;

    [Header("Colores por grupo")]
    public Color colorGrupoA = Color.blue;
    public Color colorGrupoB = Color.red;

    [Header("Separación")]
    public float separacionExtra = 30f; // espacio entre grupo A y B

    private float[] alturasObjetivo;

    void Start()
    {
        alturasObjetivo = new float[barras.Length];

        AplicarColores();
        AplicarSeparacion();
    }

    void Update()
    {
        AnimarBarras();
    }

    public void Actualizar(float[] datos)
    {
        for (int i = 0; i < barras.Length; i++)
        {
            float altura = (datos[i] / valorMax) * alturaMax;
            alturasObjetivo[i] = altura;
        }
    }

    void AnimarBarras()
    {
        for (int i = 0; i < barras.Length; i++)
        {
            float alturaActual = barras[i].sizeDelta.y;

            float nuevaAltura = Mathf.Lerp(
                alturaActual,
                alturasObjetivo[i],
                Time.deltaTime * velocidadAnimacion
            );

            barras[i].sizeDelta = new Vector2(
                barras[i].sizeDelta.x,
                nuevaAltura
            );
        }
    }

    void AplicarColores()
    {
        for (int i = 0; i < imagenes.Length; i++)
        {
            if (i < 2)
                imagenes[i].color = colorGrupoA; // Grupo A
            else
                imagenes[i].color = colorGrupoB; // Grupo B
        }
    }

    void AplicarSeparacion()
    {
        // mueve las barras del grupo B hacia la derecha
        for (int i = 2; i < barras.Length; i++)
        {
            barras[i].anchoredPosition += new Vector2(separacionExtra, 0);
        }
    }
}