using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject player1;
    [SerializeField]
    GameObject player2;
    //used to get the robotReady Bool
    public PlayerInputHandler player1Input;
    public PlayerInputHandler player2Input;
   
    //used to change the inputs from Menu to InGame when players are ready
    public PlayerInput player1Controls;
    public PlayerInput player2Controls;

    //to make a funtion stop running when the conditions are met
    private bool playersReady;
    private bool player1Found;
    private bool player2Found;

    private Animator arenaAnim;

    public GameObject tvPlayer1;
    public GameObject tvPlayer2;
    private Animator tvPlayer1Anim;
    private Animator tvPlayer2Anim;

    private void Awake()
    {
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");

        tvPlayer1Anim = tvPlayer1.GetComponent<Animator>();
        tvPlayer2Anim = tvPlayer2.GetComponent<Animator>();

        arenaAnim = GameObject.Find("Arena").GetComponent<Animator>();
    }
    void Update()
    {
        //when the players press a button and join, get access to their ready bool and get control over their input(action maps)
        if (!player1Found)
        {
            player1Input = GameObject.FindGameObjectWithTag("player1Input").GetComponent<PlayerInputHandler>();//holds robotReady bool 
            player1Controls = GameObject.FindGameObjectWithTag("player1Input").GetComponent<PlayerInput>();
            player1Found = true;
            Debug.Log("player1 Joined");
        }
        else if (!player2Found)
        {
            player2Input = GameObject.FindGameObjectWithTag("player2Input").GetComponent<PlayerInputHandler>();
            player2Controls = GameObject.FindGameObjectWithTag("player2Input").GetComponent<PlayerInput>();
            player2Found = true;
            Debug.Log("player2 Joined");

        }

        //if players are ready, change their controls
        if (player1Input.player1Ready && player2Input.player2Ready && playersReady == false)
        {
            playersReady = true;
            Debug.Log("Game Started!");
            player1Controls.SwitchCurrentActionMap("InGame");
            player2Controls.SwitchCurrentActionMap("InGame");

            //put the robots in the fighting ground   
            StartCoroutine(putPlayersInRing());

            //make them smaller 
            player1.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
            player2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);

            //enable the movement script
            player1.GetComponent<Movement>().enabled = true;
            player2.GetComponent<Movement>().enabled = true;

            arenaAnim.SetTrigger("closeCurtains");
            arenaAnim.SetTrigger("boxRingUp");

            //enable attacking script
            player1.GetComponentInChildren<Attacking>().enabled = true;
            player2.GetComponentInChildren<Attacking>().enabled = true;

            //show health
            /*player1.transform.GetChild(1).gameObject.SetActive(true);
            player2.transform.GetChild(1).gameObject.SetActive(true);*/

            //pull the TVs out
            tvPlayer1Anim.SetTrigger("tv");
            tvPlayer2Anim.SetTrigger("tv");
        }
    }
    IEnumerator putPlayersInRing()
    {
        yield return new WaitForSeconds(2);
        player1.transform.position = player1.transform.position + new Vector3(0, 4, 0);
        player2.transform.position += new Vector3(0, 4, 0);
    }
}
