using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField] private GameObject endGamePanel;
    [SerializeField] private TextMeshProUGUI textoTempoFinal;
    private bool fimMostrado = false;

    void Start()
    {
        endGamePanel.SetActive(false);
        fimMostrado = false;
    }

    void Update()
    {
        if (!fimMostrado && (GameController.gameOver || CronometroTMP.cronometroZerado))
        {   
            fimMostrado = true;
            StartCoroutine(PausarComDelay());
            endGamePanel.SetActive(true);
        }
    }

    private System.Collections.IEnumerator PausarComDelay()
    {
        yield return null;
        Time.timeScale = 0f;
    }
}
