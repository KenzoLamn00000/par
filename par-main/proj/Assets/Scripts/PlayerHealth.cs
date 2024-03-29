using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Image healthBar;
    public int realth;
    public int maxRealth = 100;
    public float healthAmount = 100f;

    private bool isDead;

    public GameManagerScript gameManager;

    // Start is called before the first frame update
    void Start()
    {
        realth = maxRealth;
    }

    // Update is called once per frame
    public void TakeDamage(int amount, float dmg) {
        realth -= amount;
        Debug.Log(realth);
        healthAmount -= dmg;
        healthBar.fillAmount = healthAmount / 100f;
        if (realth <= 0 && !isDead) {
            isDead = true;
            //gameObject.SetActive(false);
            gameManager.gameOver();
        }
    }
}
