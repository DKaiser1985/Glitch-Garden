using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Attcker))]
public class Robot : MonoBehaviour
{

    private Animator anim;
    private Attcker attacker;
    private Health currentHealth;

    // Use this for initialization
    void Start()
    {

        anim = GetComponent<Animator>();
        attacker = GetComponent<Attcker>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject obj = collider.gameObject;

        //Check to make sure collision is with a defender else return
        if (!obj.GetComponent<Defender>())
        {
            return;
        }
        //If it is a stone, then Jump
        if (obj.GetComponent<Stone>())
        {
            //attacker = GetComponent<Attcker>();
            anim.SetTrigger("TriggerBotJump");
            //attacker.currentSpeed *= 4;
        }

        else {
            anim.SetBool("BotAttacking", true);
            attacker.Attack(obj);
            Debug.Log("Robot attacked " + obj);
        }
        Debug.Log("Robot Collided with " + collider);
    }
}
