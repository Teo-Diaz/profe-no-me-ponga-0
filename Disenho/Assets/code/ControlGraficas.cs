using UnityEngine;
using UnityEngine.UI;

public class ControlGraficas : MonoBehaviour
{
    public Slider slider;

    public DataSet[] dataSets;

    public GraficaBarras barras;
    public GraficaLinea linea;
    public GraficaDona dona;

    void Start()
    {
        slider.wholeNumbers = true;
        slider.maxValue = dataSets.Length - 1;

        slider.onValueChanged.AddListener(CambiarDatos);

        CambiarDatos(slider.value);
    }

    void CambiarDatos(float value)
    {
        int index = (int)value;
        float[] datos = dataSets[index].valores;

        barras.Actualizar(datos);
        linea.Actualizar(datos);
        dona.Actualizar(datos);
    }
}