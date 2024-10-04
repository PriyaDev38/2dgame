using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    int Score = 0;
    public Text scoretext;
    public GameObject pannel;

    private void Start()
    {
        Time.timeScale = 1;
        closeDeadScreen();
    }

    public void enemyKill() {
        Score++;
        scoretext.text = "Kills : " + Score;
    }

    public void resetScore() {
        Score = 0;
    }


    public void ShowDeadScreen() {
        pannel.SetActive(true);
    }
    public void closeDeadScreen() {
        pannel.SetActive(false);
    }

    public void restart() {
        SceneManager.LoadScene(0);
    }


}
