using UnityEngine;
using System.Collections;
using UnityEngine.UI;
// Script de Unity (1 referencia de recurso) | 0 referencias
public class DadoManager : MonoBehaviour
{
    public Sprite[] diceFaces;
    public Image diceImage;
    public float rollDuration = 1f;
    private bool isRolling = false;
    // 0 referencias
    public void OnDiceClicked()
    {
        if (!isRolling)
        {
            StartCoroutine(RollDice());
        }
    }
    // 1 referencia
    IEnumerator RollDice()
    {
        isRolling = true;
        float elapsedTime = 0f;
        while (elapsedTime < rollDuration)
        {
            diceImage.sprite =
                diceFaces[Random.Range(0, diceFaces.Length)];
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        int numeroDado = Random.Range(1, 7);
        diceImage.sprite = diceFaces[numeroDado - 1];
        PlayerManager.instancia.pasosRestantes = numeroDado + 1;
        PlayerManager.instancia.mover = true;
        isRolling = false;
    }
}
