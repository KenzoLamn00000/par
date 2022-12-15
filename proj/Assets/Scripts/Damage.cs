using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace CodeMonkey.HealthSystemCM {

    public class Damage : MonoBehaviour {

        [SerializeField] private GameObject getHealthSystemGameObject;

        private void Start() {
            HealthSystem.TryGetHealthSystem(getHealthSystemGameObject, out HealthSystem healthSystem, true);


            
        }

        private void OnCollisionEnter2D(Collision2D collision) {
            HealthSystem.TryGetHealthSystem(getHealthSystemGameObject, out HealthSystem healthSystem, true);
            if(collision.gameObject.tag == "Player") {
                healthSystem.Damage(10);
            }
        }

    }

}
