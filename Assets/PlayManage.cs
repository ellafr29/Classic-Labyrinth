using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayManage : MonoBehaviour
{
    [SerializeField] GameObject finishedCanvas;
    [SerializeField] TMP_Text finishedText;
    [SerializeField] CustomEvent gameOverEvent;
    [SerializeField] CustomEvent playerWinEvent;

    int coin = 100;

    private void OnEnable()
    {
        gameOverEvent.OnInvoked.AddListener(GameOver);
        playerWinEvent.OnInvoked.AddListener(PlayerWin);
    }

    private void OnDisable()
    {
        gameOverEvent.OnInvoked.RemoveListener(GameOver);
        playerWinEvent.OnInvoked.RemoveListener(PlayerWin);
    }

    public void GameOver()
    {
        finishedText.text = "You Lost";
        finishedCanvas.SetActive(true);
    }

    public void PlayerWin()
    {
        finishedText.text = "You Win!\nScore: "+GetScore();
        finishedCanvas.SetActive(true);
    }

    private int GetScore()
    {
        return coin * 10;
    }
}
