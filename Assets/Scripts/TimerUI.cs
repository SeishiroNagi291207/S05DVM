using UnityEngine;
using TMPro;

public class TimerUI : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    private float tiempo = 0f;
    public bool activo = false;

    void Update()
    {
        if (!activo) return;

        tiempo += Time.deltaTime;

        int minutos = Mathf.FloorToInt(tiempo / 60);
        int segundos = Mathf.FloorToInt(tiempo % 60);

        timerText.text = minutos.ToString("00") + ":" + segundos.ToString("00");
    }
}