using UnityEngine;
using TMPro;
using UnityEngine.UI;
// Script de Unity (1 referencia de recurso) | 3 referencias
public class UIPreguntaManager : MonoBehaviour
{
    // 4 referencias
    public static UIPreguntaManager instance { get; private set; }
    public TMP_Text preguntaText;
    public Button[] botonesOpciones;
    public Canvas canvas;
    private Pregunta preguntaActual;
    // Mensaje de Unity | 0 referencias
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        canvas.gameObject.SetActive(false);
    }
    // 1 referencia
    public void VerificarRespuesta(int index)
    {
        if (index == preguntaActual.indiceCorrecto)
        {
            PlayerManager.instancia.mover = true;
            canvas.gameObject.SetActive(false);
        }
        else
        {
            PlayerManager.instancia.pasosRestantes = 1;
            PlayerManager.instancia.posicionPunto = 0;
            PlayerManager.instancia.mover = true;
            canvas.gameObject.SetActive(false);
        }
    }
    // 2 referencias
    public void MostrarPregunta(Pregunta pregunta)
    {
        canvas.gameObject.SetActive(true);
        preguntaText.text = pregunta.enunciado;
        preguntaActual = pregunta;
        for (int i = 0; i < botonesOpciones.Length; i++)
        {
            int index = i;
            botonesOpciones[i].GetComponentInChildren<TMP_Text>().text = pregunta.opciones[i];
            botonesOpciones[i].onClick.RemoveAllListeners();
            botonesOpciones[i].onClick.AddListener(() => VerificarRespuesta(index));
        }
    }
}