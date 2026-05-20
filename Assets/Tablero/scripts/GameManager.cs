using UnityEngine;
// Script de Unity (1 referencia de recurso) | 1 referencia
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
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
    }
}