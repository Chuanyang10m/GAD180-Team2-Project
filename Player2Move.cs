using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Move : MonoBehaviour
{
    private CharacterController chaController;
    private CharacterAnimations playerAnimations;

    public float movement_Speed = 3f;
    public float gravity = 9.8f;
    public float rotation_Speed = 0.15f;
    public float rotateDegreesPerSecond = 180f;


    void Awake()
    {
        // fetch the CharacterController component
        chaController = GetComponent<CharacterController>();

        // fetch the AnimationController component
        playerAnimations = GetComponent<CharacterAnimations>();

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
        AnimateWalk();
    }

    void Move()
    {
        // move foward
        if (Input.GetAxis("Vertical_2") > 0)
        {
            Vector3 moveDirection = transform.forward;
            moveDirection.y -= gravity * Time.deltaTime;

            chaController.Move(moveDirection * movement_Speed * Time.deltaTime);
        }


        //move backward
        else if (Input.GetAxis("Vertical_2") < 0)
        {
            Vector3 moveDirection = -transform.forward;
            moveDirection.y -= gravity * Time.deltaTime;

            chaController.Move(moveDirection * movement_Speed * Time.deltaTime);
        }

        else
            chaController.Move(Vector3.zero);

    }//Move

    void Rotate()
    {
        Vector3 rotate_Direction = Vector3.zero;

        //change the direction of RIGHT input from local to world space
        if(Input.GetAxis("Horizontal_2") >0)
        {
            rotate_Direction = transform.TransformDirection(Vector3.right);
        }

        //change the direction of LEFT input from local to world space
        if (Input.GetAxis("Horizontal_2") < 0)
        {
            rotate_Direction = transform.TransformDirection(Vector3.left);
        }

        //rotate the character
        if(rotate_Direction != Vector3.zero)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation,
                Quaternion.LookRotation(rotate_Direction),rotateDegreesPerSecond*Time.deltaTime);
        }

    }// Rotate


    void AnimateWalk()
    {
        // when there is velocity, play Walk animation
        if (chaController.velocity.sqrMagnitude != 0f)
        {
            playerAnimations.Walk(true);
        }
        else
            playerAnimations.Walk(false);



    }










}
