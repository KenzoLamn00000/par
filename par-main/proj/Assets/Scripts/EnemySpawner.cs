using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public ScoreScript score;
    public int scoreCount;

    [SerializeField]
    private GameObject slimePrefab;

    [SerializeField]
    private float slimeInterval = 3.5f;

    [SerializeField]
    private GameObject slimePrefab2;

    [SerializeField]
    private float slimeInterval2 = 10f;


    public bool canMove;
    private DialogueManager DM;


    // Start is called before the first frame update
    void Start()
    {
        //scoreCount = score.GetComponent<ScoreScript>().GetScore();
        StartCoroutine(spawnEnemy(slimeInterval, slimePrefab));
        StartCoroutine(spawnEnemy2(slimeInterval2, slimePrefab2));
    }

    void Update() {
        //if (scoreCount >= 10) {
          //  slimeInterval = 2.0f;
            //Debug.Log("hi");
        //}
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy) {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-7f, 7f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy)); 
    }

    private IEnumerator spawnEnemy2(float interval, GameObject enemy) {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-7f, 7f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy2(interval, enemy)); 
    }
    

}
