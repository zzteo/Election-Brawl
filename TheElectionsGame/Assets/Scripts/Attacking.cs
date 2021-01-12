using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking : MonoBehaviour
{
    [SerializeField]
    GameObject player1;
    [SerializeField]
    GameObject player2;

    [SerializeField]
    private int playerIndex;

    public Animator anim;
    public float noOfhits = 0;
    float lastTapTime = 0;
    public float maxComboDelay = 2f;
    public bool collisionWithEnemy;

    private Animator playerAnim;
    private bool anim1Found;
    public Animator player2Anim;
    private bool anim2Found;

    public SpecialAttackScript player1SpecialAttack;
    public SpecialAttackScript player2SpecialAttack;

    [SerializeField] ParticleSystem hit;
    [SerializeField] ParticleSystem hitUlt;
    [SerializeField] ParticleSystem hitHeavy;
    [SerializeField] Transform hitPoint;


    [SerializeField] AudioSource[] audio;
    //[1]=lightAttack12; [2]= lightAttack3; [3]= hardAttack;
    public int GetPlayerIndex()
    {
        return playerIndex;
    }

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();

        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
    }


    private void Update()
    {
        //attacking script runs when the game starts, then it finds the animators so I can use the takeDamageAnim and then stops running
        if (!anim1Found)
        {
            playerAnim = player1.GetComponentInChildren<Animator>();//se repeta
            anim1Found = true;
            Debug.Log("dadad");
            playerAnim.SetBool("idleInGame", true);

        }
        if (!anim2Found)
        {
            player2Anim = player2.GetComponentInChildren<Animator>();
            anim2Found = true;
            player2Anim.SetBool("idleInGame", true);
        }

        if (Time.time - lastTapTime > maxComboDelay)
        {
            noOfhits = 0;
        }       
    }

    public void Attack()
    {
        lastTapTime = Time.time;
        noOfhits++;
        noOfhits = Mathf.Clamp(noOfhits, 0, 3);

        if (noOfhits == 1)
        {
            anim.SetBool("lightAttack1", true);
        }
    }

    public void HeavyAttack()
    {
        anim.SetTrigger("heavyAttack");
    }

    //the return functions are used for every attack, the function runs as an event and it's triggered by the corresponding attack animation
    public void return1()
    {

        if (playerIndex == 0 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player2Input").GetComponent<PlayerInputHandler>().isGuarding == false)
        {
            player2.GetComponent<PlayerHealth>().TakeDamage(10);
            player2Anim.SetTrigger("gotHit");        
            player1SpecialAttack.AddSpecialBarPoints(20);
            Instantiate(hit, hitPoint.transform);
            //play audio
            audio[0].Play();

        }
        else if (playerIndex == 1 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player1Input").GetComponent<PlayerInputHandler>().isGuarding == false)
        {
            player1.GetComponent<PlayerHealth>().TakeDamage(10);
            playerAnim.SetTrigger("gotHit");         
            player2SpecialAttack.AddSpecialBarPoints(20);
            Instantiate(hit, hitPoint.transform);
            audio[0].Play();
        }

        else
        {

            if (playerIndex == 0 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player2Input").GetComponent<PlayerInputHandler>().isGuarding == false) //unotimized but so far works, change it later if it causes problems 
            {
                player2.GetComponent<PlayerHealth>().TakeDamage(10);
                player2Anim.SetTrigger("gotHit");
                player1SpecialAttack.AddSpecialBarPoints(20);
                Instantiate(hit, hitPoint.transform);
            }
            else if (playerIndex == 1 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player1Input").GetComponent<PlayerInputHandler>().isGuarding == false)
            {
                player1.GetComponent<PlayerHealth>().TakeDamage(10);
                playerAnim.SetTrigger("gotHit");
                player2SpecialAttack.AddSpecialBarPoints(20);
                Instantiate(hit, hitPoint.transform);
            }
            else if (playerIndex == 0 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player2Input").GetComponent<PlayerInputHandler>().isGuarding == true)
            {
                //play punch blocked sound
                audio[3].Play();
            }
            else if (playerIndex == 1 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player1Input").GetComponent<PlayerInputHandler>().isGuarding == true)
            {
                //play punch blocked sound
                audio[3].Play();
            }
        }
    }

    public void return1Check()
    {
        if (noOfhits >= 2)
        {
            anim.SetBool("lightAttack2", true);
        }
        else
        {
            anim.SetBool("lightAttack1", false);
            noOfhits = 0;
        }
    }
    public void return2()
    {
            if (playerIndex == 0 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player2Input").GetComponent<PlayerInputHandler>().isGuarding == false)
            {
                player2.GetComponent<PlayerHealth>().TakeDamage(10);
                player2Anim.SetTrigger("gotHit");
            player1SpecialAttack.AddSpecialBarPoints(20);
            Instantiate(hit, hitPoint.transform);
            //play audio
            audio[0].Play();
        }
            else if (playerIndex == 1 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player1Input").GetComponent<PlayerInputHandler>().isGuarding == false)
            {
                player1.GetComponent<PlayerHealth>().TakeDamage(10);
                playerAnim.SetTrigger("gotHit");
            player2SpecialAttack.AddSpecialBarPoints(20);
            Instantiate(hit, hitPoint.transform);
            audio[0].Play();
        }
        else if (playerIndex == 0 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player2Input").GetComponent<PlayerInputHandler>().isGuarding == true)
        {
            //play punch blocked sound
            audio[3].Play();
        }
       

        else
        {
            if (playerIndex == 0 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player2Input").GetComponent<PlayerInputHandler>().isGuarding == false)
            {
                player2.GetComponent<PlayerHealth>().TakeDamage(10);
                player2Anim.SetTrigger("gotHit");
                player1SpecialAttack.AddSpecialBarPoints(20);
                Instantiate(hit, hitPoint.transform);
            }
            else if (playerIndex == 1 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player1Input").GetComponent<PlayerInputHandler>().isGuarding == false)
            {
                player1.GetComponent<PlayerHealth>().TakeDamage(10);
                playerAnim.SetTrigger("gotHit");
                player2SpecialAttack.AddSpecialBarPoints(20);
                Instantiate(hit, hitPoint.transform);
            }
            else if (playerIndex == 1 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player1Input").GetComponent<PlayerInputHandler>().isGuarding == true)
            {
                //play punch blocked sound
                audio[3].Play();
            }
        }
    }

    public void retunr2Check()
    {
        if (noOfhits == 3)
        {
            anim.SetBool("lightAttack1", false);
            anim.SetBool("lightAttack3", true);
        }
        else
        {
            anim.SetBool("lightAttack1", false);
            anim.SetBool("lightAttack2", false);
            noOfhits = 0;

        }

    }
    public void return3()
    {
        anim.SetBool("lightAttack1", false);
        anim.SetBool("lightAttack2", false);
        anim.SetBool("lightAttack3", false);
        noOfhits = 0;

        if (playerIndex == 0 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player2Input").GetComponent<PlayerInputHandler>().isGuarding == false) 
        {
            player2.GetComponent<PlayerHealth>().TakeDamage(10);
            player2Anim.SetTrigger("gotHit");
            player1SpecialAttack.AddSpecialBarPoints(20);
            Instantiate(hit, hitPoint.transform);
            //play audio
            audio[1].Play();
        }
        else if (playerIndex == 1 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player1Input").GetComponent<PlayerInputHandler>().isGuarding == false)
        {
            player1.GetComponent<PlayerHealth>().TakeDamage(10);
            playerAnim.SetTrigger("gotHit");
            player2SpecialAttack.AddSpecialBarPoints(20);
            Instantiate(hit, hitPoint.transform);
            audio[1].Play();
        }
        else if (playerIndex == 0 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player2Input").GetComponent<PlayerInputHandler>().isGuarding == true)
        {
            //play punch blocked sound
            audio[3].Play();
        }
        else if (playerIndex == 1 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player1Input").GetComponent<PlayerInputHandler>().isGuarding == true)
        {
            //play punch blocked sound
            audio[3].Play();
        }
    }

    public void returnHeavyAttack()
    {
        if (playerIndex == 0 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player2Input").GetComponent<PlayerInputHandler>().isGuarding == false)
        {
            player2.GetComponent<PlayerHealth>().TakeDamage(20);
            player2Anim.SetTrigger("gotHit");
            player1SpecialAttack.AddSpecialBarPoints(30);
            Instantiate(hitHeavy, hitPoint.transform);
            //play audio
            audio[2].Play();
        }
        else if (playerIndex == 1 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player1Input").GetComponent<PlayerInputHandler>().isGuarding == false)
        {
            player1.GetComponent<PlayerHealth>().TakeDamage(20);
            playerAnim.SetTrigger("gotHit");   
            player2SpecialAttack.AddSpecialBarPoints(30);
            Instantiate(hitHeavy, hitPoint.transform);
            audio[2].Play();
        }
        else if (playerIndex == 0 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player2Input").GetComponent<PlayerInputHandler>().isGuarding == true)
        {
            //play punch blocked sound
            audio[3].Play();
        }
        else if (playerIndex == 1 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player1Input").GetComponent<PlayerInputHandler>().isGuarding == true)
        {
            //play punch blocked sound
            audio[3].Play();
        }
    }

    public void returnSpecialAttack()
    {
        if (playerIndex == 0 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player2Input").GetComponent<PlayerInputHandler>().isGuarding == false)
        {
            player2.GetComponent<PlayerHealth>().TakeDamage(30);
            player2Anim.SetTrigger("gotHitUlt");
            Instantiate(hitUlt, hitPoint.transform);
        }
        else if (playerIndex == 1 && collisionWithEnemy == true && GameObject.FindGameObjectWithTag("player1Input").GetComponent<PlayerInputHandler>().isGuarding == false)
        {
            player1.GetComponent<PlayerHealth>().TakeDamage(30);
            playerAnim.SetTrigger("gotHitUlt");
            Instantiate(hitUlt, hitPoint.transform);
        }
    }

    public void specialAttack()
    {
        if(playerIndex == 0)
        {
            player1SpecialAttack.SetProgress(0);
            player1SpecialAttack.currentProgress = 0;

            playerAnim.SetTrigger("ult");
        }
        else if(playerIndex == 1)
        {
            player2SpecialAttack.SetProgress(0);
            player2SpecialAttack.currentProgress = 0;

            player2Anim.SetTrigger("ult");
        }
        // set the corresponding anim 
        // make a return function and put the thing in the anim itself 
        Debug.Log("specialAttack executed");       

    }
    public void Guard()
    {
        anim.SetBool("guard", true);
    }
    public void CancelGuard()
    {
        anim.SetBool("guard", false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player2" || other.gameObject.name == "Player1")
        {
            collisionWithEnemy = true;
            Debug.Log("collides with enemy");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player2" || other.gameObject.name == "Player1")//am pus partea a doua cu player 1, in caz ca se strica cv :))
        {
            collisionWithEnemy = false;
        }
    }

}
