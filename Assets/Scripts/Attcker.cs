using UnityEngine;
using System.Collections;

public class Attcker : MonoBehaviour {

    [Range(-1f, 1.5f)]
    public float currentSpeed;
    public float damageDealt;



	// Use this for initialization
	void Start () {
        Rigidbody2D myRigidbody = gameObject.AddComponent<Rigidbody2D>();
        myRigidbody.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
	}
    void OnTriggerEnter2D(){
        Debug.Log(name + " Trigger Enter!");
        StrikeCurrentTarget(damageDealt);
    }
    public void SetSpeed(float speed)
    {
        currentSpeed = speed;
    }
    void StrikeCurrentTarget(float damage)
    {
        Debug.Log(name + " Damage dealt: " + damage);
    }
}
