using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject Attacker;
    public GameObject Defender;
    void Update()
    {
        if (Input.GetKeyDown((KeyCode.Space)))
        { DoAttack(); }
    }
 public void DoAttack(){
    Attacker.GetComponent<Animator>().SetTrigger("Hook Punch");
}
public void Defend(){

    Defender.GetComponent<Animator>().SetTrigger("Right Block (2)");

}
    }
