using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HealthScript : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public PlayerHealth playerScript;
    public GameObject player;
    public GameObject otherPlayer;
    private Animator playerAnim;
    private bool anim1Found;
    private Animator otherPlayerAnim;
    private bool anim2Found;

    public GameManager GM;
  

    /* [SerializeField]
     ParticleSystem DyingParticles;*/

    //deci am facut asta sa mearga fara ca macar sa gandesc :))
    //animatorurile le va cauta dupa ce playerii sunt ready, pt ca pana atunci sun dezactivate si codul nu ruleaza

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    public void SetHealth(int health)
    {
        slider.value = health;
    }
    public void Update()
    {
        if (!anim1Found)
        {
            playerAnim = player.GetComponentInChildren<Animator>();
            anim1Found = true;
        }
        if (!anim2Found)
        {
            otherPlayerAnim = otherPlayer.GetComponentInChildren<Animator>();//vezi cum faci :)) trb sa ma culc
            anim2Found = true;
        }

        if (playerScript.currentHealth <= 0)
        {
            /*Instantiate(DyingParticles, player.transform.position, player.transform.rotation);        */
            Debug.Log("Player dead");
            //start dead anim
            playerAnim.SetTrigger("lose");
            StartCoroutine(Wait10sWin());

            //disable inputs 
            GM.player1Controls.DeactivateInput();
            GM.player2Controls.DeactivateInput();
        }
    }
    //waits 6 seconds so the player finishes winnning animation, then restarts the scene
    private IEnumerator Wait10sWin() {
        otherPlayerAnim.SetTrigger("win");
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene("MainScene");
    }
}
