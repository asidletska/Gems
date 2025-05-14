using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int moves;
    private int currentMoves = 0;

    [Header("UIElements")]
    public GameObject winPanel;
    public GameObject losePanel;

    [SerializeField] public TMP_Text movesText;

    public void OnPlayerMove()
    {
        moves--;
        movesText.text = $"{moves}";
        if (moves == currentMoves)
        {
            LevelFailed();
        }
    }
    public void LevelComplete()
    {
        Time.timeScale = 0;
        winPanel.SetActive(true);
    }
    private void LevelFailed()
    {
        Time.timeScale = 0;
        losePanel.SetActive(true);
    }
}

