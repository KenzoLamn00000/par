using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject slimePrefab;

    [SerializeField]
    private float slimeInterval = 3.5f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(slimeInterval, slimePrefab));

    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy) {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-3f, 3), Random.Range(-5f, 5f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy)); 


        }
}
