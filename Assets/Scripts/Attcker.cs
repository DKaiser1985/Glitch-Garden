using UnityEngine;
using System.Collections;

public class Attcker : MonoBehaviour {

    [Range(-1f, 1.5f)]
    private float currentSpeed;
    private GameObject currentTarget;
    public float damageDealt;



	// Use this for initialization
	void Start () {
        //Rigidbody2D myRigidbody = gameObject.AddComponent<Rigidbody2D>();
        //myRigidbody.isKinematic = true;
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
	}
    void OnTriggerEnter2D()
    {
        StrikeCurrentTarget(damageDealt);
    }
    public void SetSpeed(float speed)
    {
        currentSpeed = speed;
    }
    void StrikeCurrentTarget(float damage)
    {
        if (currentTarget) {
            Health health = currentTarget.GetComponent<Health>();
            //if (health)
            //{
                
                health.DealDamage(damage);
                Debug.Log(health);
            //}
        }
    }
    public void Attack(GameObject obj)
    {
        currentTarget = obj;
    }
}
