using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayManage : MonoBehaviour
{
    [SerializeField] GameObject finishedCanvas;
    [SerializeField] TMP_Text finishedText;

    int coin = 100;

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
