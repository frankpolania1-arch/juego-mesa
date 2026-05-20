using TMPro;
using UnityEngine;
// Script de Unity (1 referencia de recurso) | 1 referencia
public class GameManager : MonoBehaviour
{

    [Header("CanvaPuntos")]
    public TextMeshProUGUI TXTpuntos;

    int puntos = 0;


    public static GameManager instance;
    // Mensaje de Unity | 0 referencias
    void Awake()
    {
        TXTpuntos.text = "Puntos: " + puntos;
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }



    public void Puntuacion(bool punto)
    {
        if (punto)
        {
            puntos++;
            TXTpuntos.text = "Puntos " + puntos;

        }
        else {
            puntos--;
            if (puntos == 0)
            {
                return;
            }
            TXTpuntos.text = "Puntos: " + puntos;
            
        }

    }

}
