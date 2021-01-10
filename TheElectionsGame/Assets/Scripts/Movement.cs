using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private int playerIndex = 0;

    public Rigidbody rb;

    [SerializeField]
    private float moveSpeed = 10f;

    private Vector2 movementInput;
    private Vector3 inputDirection;
    private Vector3 moveVector;
    private Quaternion currentRotation;
    public Vector3 desiredDirection;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = movementInput.x;
        float v = movementInput.y;

        Vector3 targetInput = new Vector3(h, 0, v);

        inputDirection = Vector3.Lerp(inputDirection, targetInput, Time.deltaTime * 10f);

        Vector3 camForward = Camera.main.transform.forward;
        Vector3 camRight = Camera.main.transform.right;
        camForward.y = 0f;
        camRight.y = 0f;

        Vector3 desiredDirection = camForward * inputDirection.z + camRight * inputDirection.x;

        Move(desiredDirection);
        Turn(desiredDirection);
    }
    public void Move(Vector3 desiredDirection)
    {
        moveVector.Set(desiredDirection.x, 0f, desiredDirection.z);
        moveVector = moveVector * moveSpeed * Time.deltaTime;
        /* transform.position += moveVector;*/
        rb.AddForce(transform.forward + moveVector);
    }
    public void Turn(Vector3 desiredDirection)
    {
        if ((desiredDirection.x > 0.1 || desiredDirection.x < -0.1 || desiredDirection.z > 0.1 || desiredDirection.z < -0.1))
        {
            currentRotation = Quaternion.LookRotation(desiredDirection);
            transform.rotation = currentRotation;
        }
        else
        {
            transform.rotation = currentRotation;
        }
    }

    public void SetInputVector(Vector2 direction)
    {
        movementInput = direction;
    }

    public int GetPlayerIndex()
    {
        return playerIndex;
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.name == "Cube")
        {
           if( rb.velocity.sqrMagnitude < rb.sleepThreshold)
            {
                this.GetComponentInChildren<Animator>().SetBool("run", false);
            }else
                this.GetComponentInChildren<Animator>().SetBool("run", true);
        }
    }
}
