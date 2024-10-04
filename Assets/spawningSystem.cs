using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawningSystem : MonoBehaviour
{
    public float spwanTime = 1f;
    public GameObject enemy;
    private void Start()
    {
        StartCoroutine(startSpawing());
    }

    IEnumerator startSpawing() {

        yield return new WaitForSeconds(spwanTime);
        Instantiate(enemy, transform.position, Quaternion.identity);

        StartCoroutine(startSpawing());
    }
}
