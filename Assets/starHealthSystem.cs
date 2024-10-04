using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starHealthSystem : MonoBehaviour
{
    public float maxHealth = 100f;
    float damageTaken = 0;
    public healthbarSystem healthbarSystem;
    public gameManager gameMG;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy") {
            if (damageTaken < maxHealth)
            {

                damageTaken += Time.deltaTime;
                healthbarSystem.RemoveHealth((maxHealth - damageTaken) / maxHealth);
            }
            else {
                Debug.Log("Died");
                Time.timeScale = 0;
                gameMG.ShowDeadScreen();
            }
        }
    }


}
