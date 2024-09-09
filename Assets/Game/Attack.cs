using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject Attacker_Player;
    public GameObject Defender_Player;
    void Update()
    {
        if (Input.GetKeyDown((KeyCode.Space)))
        { DoAttack(); }
    }
 public void DoAttack(){
    Attacker_Player.GetComponent<Animator>().SetTrigger("Punch");
}
public void Defend(){

    Defender_Player.GetComponent<Animator>().SetTrigger("Block");

}
public void Bodyhit(){
    Attacker_Player.GetComponent<Animator>().SetTrigger("Hit");
}
    }
