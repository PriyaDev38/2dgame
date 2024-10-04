using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyhealthcode : MonoBehaviour
{
    public int numofBullettokill = 4;
    int numofBulletTaken = 1;
    public gameManager gamemg;

    private void Start()
    {
        gamemg = FindAnyObjectByType<gameManager>();
    }

    public void bulletHit()
    {
        if (numofBullettokill > numofBulletTaken)
        {
            numofBulletTaken++;
            Debug.Log("Bullet Hit : " + numofBulletTaken);

        }
        else
        {
            gamemg.enemyKill();
            Destroy(gameObject);
        }

    }
}
