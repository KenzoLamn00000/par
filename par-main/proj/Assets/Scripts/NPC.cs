using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{

    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public bool playerInRange;
    public bool talking; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        talking = false;
        if(Input.GetKeyDown(KeyCode.Space)&&playerInRange) {
            if(dialogBox.activeInHierarchy) {
                dialogBox.SetActive(false);
            } else {
                dialogBox.SetActive(true);
                dialogText.text = dialog;
                talking = true;
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player") {
          //Debug.Log("INRange");
           playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Player")) {
            //Debug.Log("outrange");
            playerInRange = false;
            dialogBox.SetActive(false);
        }
    }
}
