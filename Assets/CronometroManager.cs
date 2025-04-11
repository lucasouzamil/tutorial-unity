using UnityEngine;
using TMPro;

public class CronometroTMP : MonoBehaviour
{
    public TextMeshProUGUI tempoTexto;
    
    public float tempoRestante = 10f;
    private bool contando = true;

    public static bool cronometroZerado { get; private set; } = false;

    void Update()
    {
        if (contando)
        {
            if (tempoRestante > 0)
            {   
                tempoRestante -= Time.deltaTime;

                float tempoExibido = Mathf.Max(tempoRestante, 0f);

                int segundos = Mathf.FloorToInt(tempoExibido);
                int milissegundos = Mathf.FloorToInt((tempoExibido - segundos) * 100);

                string tempoFormatado = string.Format("{0:00}.{1:00}", segundos, milissegundos);

                tempoTexto.text = tempoFormatado;
            }
            else
            {
                contando = false;
                tempoTexto.text = "00.00";
                cronometroZerado = true;
            }
        }
    }

    public void PararCronometro()
    {
        contando = false;
    }

    public void ReiniciarCronometro(float novoTempo)
    {
        tempoRestante = novoTempo;
        contando = true;
        cronometroZerado = false;
    }
}
