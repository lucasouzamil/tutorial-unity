using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] public GameObject endGamePanel;

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
