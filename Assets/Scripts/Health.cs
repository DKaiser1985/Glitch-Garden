using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public float health = 50;
    private GameObject obj;

    public void DealDamage(float damage) {
        health -= damage;
    }
}
