using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpener : MonoBehaviour
{
    public GameObject chestClose, chestOpen, SpeedPot;

    // Start is called before the first frame update
    void Start()
    {
        chestClose.SetActive(true);
        chestOpen.SetActive(false);
        SpeedPot.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision) {
    if(collision.gameObject.CompareTag("Player")){
        chestClose.SetActive(false);
        chestOpen.SetActive(true);
        SpeedPot.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        chestClose.SetActive(true);
        chestOpen.SetActive(false);
        SpeedPot.SetActive(false);
    }
}
