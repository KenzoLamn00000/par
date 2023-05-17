using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCollector : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("SpeedPot")) {
            Destroy(collision.gameObject);
        } else if (collision.gameObject.CompareTag("Item")) {
            Destroy(collision.gameObject);
        }
    }
}
