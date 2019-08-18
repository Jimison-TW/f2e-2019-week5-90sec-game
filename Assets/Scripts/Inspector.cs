using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Inspector : MonoBehaviour
{
    public GameObject[] lifeImgs;

    private int currentLife = 3;
    private UnityAction onGameOver;

    public void addLife()
    {
        if (currentLife < 3)
        {
            lifeImgs[currentLife - 1].SetActive(true);
            currentLife++;
        }
    }

    public void loseLife()
    {
        if (currentLife > 0)
        {
            lifeImgs[currentLife - 1].SetActive(false);
            currentLife--;
        }

        if (currentLife <= 0) onGameOver.Invoke();
    }

    public void setGameOverAction(UnityAction gameOverAction)
    {
        onGameOver = gameOverAction;
    }
}
