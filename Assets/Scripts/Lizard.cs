using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attcker))]
public class Lizard : MonoBehaviour {

    private Animator anim;
    private Attcker attacker;
    
    // Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        attacker = GetComponent<Attcker>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject obj = collider.gameObject;

        if (!obj.GetComponent<Defender>())
        {
            return;
        }
        else {
            anim.SetBool("LizAttacking",true);
            attacker.Attack(obj);
            Debug.Log("Lizard attacked " + obj);
        }
        Debug.Log("Robot Collided with " + collider);
    }

}
