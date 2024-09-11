using System.Collections;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject Attacker_Player;
    public GameObject Defender_Player;
    public GameObject panelToShow;  // Assign the panel (UI screen) in the Inspector
 void  Start() {
    StartCoroutine(ShowScreenForFiveSeconds());
 }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            DoAttack();
              // Show screen when attack happens
        }
        else if (Input.GetKeyDown(KeyCode.A))
        { 
            DoNextMove(); 
        }
    }

    public void DoAttack()
    {
        Attacker_Player.GetComponent<Animator>().SetTrigger("Punch");
    }

    public void Defend()
    {
        Defender_Player.GetComponent<Animator>().SetTrigger("Block");
    }

    public void Bodyhit()
    {
        Attacker_Player.GetComponent<Animator>().SetTrigger("Hit");
    }

    public void DoNextMove()
    {
        Attacker_Player.GetComponent<Animator>().SetTrigger("Attack");
    }

    public void Ducking()
    {
        Defender_Player.GetComponent<Animator>().SetTrigger("Duck");
    }

    // Coroutine to show the screen for 5 seconds
    private IEnumerator ShowScreenForFiveSeconds()
    {
        panelToShow.SetActive(true); 
        yield return new WaitForSeconds(3);  // Wait for 5 seconds
        panelToShow.SetActive(false);  // Hide the panel after 5 seconds
    }
}
