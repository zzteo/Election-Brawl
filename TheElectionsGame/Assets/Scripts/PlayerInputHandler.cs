using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;
using static UnityEngine.InputSystem.InputAction;
using UnityEditor;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerInput playerInput;

    private SelectingCharacter selectingCharacter;
    private SpecialAttackScript specialAttack;
    private Movement mover;
    public readyIconsScript readyScript;

    private Attacking attacker;

    public bool player1Ready;
    public bool player2Ready;

    /*  GameManager GM;*/

    //animul mapei
    public Animator arenaAnim;

    private bool isRunning;
    public bool isMoving;
    public bool isGuarding;

    //when a player joins by pressing any button on their controller, a prefab called PlayerInput is created which has a PlayerInputManager attached to it
    //the events from the InputPlayerManager are called from this script

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        var index = playerInput.playerIndex;

        var characters = FindObjectsOfType<SelectingCharacter>();
        selectingCharacter = characters.FirstOrDefault(c => c.GetPlayerIndex() == index);

        var movers = FindObjectsOfType<Movement>();
        mover = movers.FirstOrDefault(m => m.GetPlayerIndex() == index);

        var specialAtt = FindObjectsOfType<SpecialAttackScript>();
        specialAttack = specialAtt.FirstOrDefault(m => m.GetPlayerIndex() == index);

        arenaAnim = GameObject.Find("Arena").GetComponent<Animator>();
        /* GM = GameObject.Find("GameManager").GetComponent<GameManager>();*/

        playerInput.SwitchCurrentActionMap("Menu");

        readyScript = GameObject.Find("Arena").GetComponent<readyIconsScript>();
    }

    //Menu
    public void SelectLeft()
    {      
            StartCoroutine(IeSelectLeft());   
    }
    public void SelectRight()
    {
           StartCoroutine(IeSelectRight());           
    }

    public void Ready()
    {
        if (playerInput.playerIndex == 0 )
        {
            player1Ready = true;

            //show ready icon;
            readyScript.ReadyP1();
           // inainte mergea sa joci si cu al 2 lea caracter, dar dupa nu stiu dc, nu a mai mers, si am constatat ca attacking script era assinged numai primului caracter din ierarhie, asta il fixeaza pt ca decide care e scriptul abia dupa ce ai dat ready
            var index = playerInput.playerIndex;
            var attakers = FindObjectsOfType<Attacking>();
            attacker = attakers.FirstOrDefault(a => a.GetPlayerIndex() == index);

            gameObject.tag = "player1Input";// set the tag to get a reference of the robot1ready in game manager           
        }
        else if (playerInput.playerIndex == 1)
        {
            player2Ready = true;

            readyScript.ReadyP2();

            var index = playerInput.playerIndex;
            var attakers = FindObjectsOfType<Attacking>();
            attacker = attakers.FirstOrDefault(a => a.GetPlayerIndex() == index);

            gameObject.tag = "player2Input"; // nu uita sa schimbi numele in gamemanager din robot2input in player....
        }
    }

    public void CancelReady()
    {      
        if (playerInput.playerIndex == 0)
        {
            player1Ready = false;
            /*GM.robot1ReadyIcon.gameObject.SetActive(false);*/

            readyScript.NotReadyP1();
        }
        else if (playerInput.playerIndex == 1)
        {
            player2Ready = false;
            /* GM.robot2ReadyIcon.gameObject.SetActive(false);*/

            readyScript.NotReadyP2();
        }
    }
    //InGame
    public void OnMove(CallbackContext context)
    {
        if (context.performed && mover !=null)
        {          
            mover.SetInputVector(context.ReadValue<Vector2>());
            mover.Move(mover.desiredDirection);
            mover.Turn(mover.desiredDirection);

             isMoving = false;
        }      
    }
    //this is how you make button press 
    public void OnAttack(CallbackContext context)
    {
        if (context.performed && attacker != null)
        {
            attacker.Attack();
            mover.enabled = false;
        }
        //so he can't move while attacking
        else
        {
            mover.enabled = true;
        }
    }

    public void OnHeavyAttack(CallbackContext context)
    {
        if (context.performed){
            attacker.HeavyAttack();
        }
    }

    public void OnSpecialAttack(CallbackContext context)
    {
        if(context.performed && specialAttack.currentProgress >= 100)
        {
            attacker.specialAttack();
            Debug.Log(specialAttack.currentProgress);
        }
    }

    public void OnGuard(CallbackContext context)
    {
        if (context.started)
        {
            attacker.Guard();
            mover.enabled = false;
            isGuarding = true;//not used currently
        }

        if (context.canceled)
        {
            attacker.CancelGuard();
            mover.enabled = true;
            isGuarding = false;
        }
    }
    /// Menuuu coroutines
    private IEnumerator IeSelectLeft()
    {
        if (isRunning == false)
        {
            if (playerInput.playerIndex == 0 && selectingCharacter.currentSelection != 0 && player1Ready==false)
            {
                arenaAnim.SetTrigger("change1");
                isRunning = true;
                selectingCharacter.currentSelection -= 1;
                selectingCharacter.Selecting();
                //so while the animmation is running you are not able to change the character 
                yield return new WaitForSeconds(2f);
                isRunning = false;
            }
            else if (playerInput.playerIndex == 1 && selectingCharacter.currentSelection != 0 && player2Ready == false)
            {
                arenaAnim.SetTrigger("change2");
                isRunning = true;
                selectingCharacter.currentSelection -= 1;
                selectingCharacter.Selecting();
                //so while the animmation is running you are not able to change the character 
                yield return new WaitForSeconds(2f);
                isRunning = false;
            }
               
        }
    }

    private IEnumerator IeSelectRight()
    {
        if (isRunning == false)
        {
            if (playerInput.playerIndex == 0 && selectingCharacter.currentSelection != selectingCharacter.transform.childCount - 1 && player1Ready == false)
            {
                arenaAnim.SetTrigger("change1");
                isRunning = true;
                selectingCharacter.currentSelection += 1;
                selectingCharacter.Selecting();
                yield return new WaitForSeconds(2f);
                isRunning = false;
            }
            else if (playerInput.playerIndex == 1 && selectingCharacter.currentSelection != selectingCharacter.transform.childCount - 1 && player2Ready == false)
            {
                arenaAnim.SetTrigger("change2");
                isRunning = true;
                selectingCharacter.currentSelection += 1;
                selectingCharacter.Selecting();
                yield return new WaitForSeconds(2f);
                isRunning = false;
            }
                
        }
    }
 
}
