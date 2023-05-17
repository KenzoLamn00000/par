using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public Text MyscoreText;
    [SerializeField] private int ScoreNum;
    public List<Loot> itemList = new List<Loot>();


    // Start is called before the first frame update
    void Start()
    {
       ScoreNum = 0;
       MyscoreText.text = "Score: " + ScoreNum;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Item") {
            Debug.Log("hi");
            ScoreNum += 10;
            MyscoreText.text = "Score: " + ScoreNum;
        }
    }

    public int GetScore() {
        return ScoreNum;
    }
}
