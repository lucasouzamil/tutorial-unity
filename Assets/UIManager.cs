using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public GameObject endGamePanel;

    void Start()
    {
        endGamePanel.SetActive(false);
    }

    void Update()
    {
        if (GameController.gameOver)
        {   
            endGamePanel.SetActive(true);
        }
    }
}
