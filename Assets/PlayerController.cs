using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    Animator anim;
    private bool isMoving;
    private bool isAttacking;
    private Rigidbody2D rigd2d;
    private Vector2 lastDirection;
    public float playerHealth;
    [SerializeField]
    private GameObject playerShield;
    public float shieldAmount;
    public bool isShieldActive;

    void Start()
    {
        anim = GetComponent<Animator>();
        rigd2d = GetComponent<Rigidbody2D>();
        isShieldActive = false;
    }

    void Update()
    {
        CheckInput();
        
    }

    void CheckInput()
    {
        isMoving = false;
        isAttacking = false;
        var h = Input.GetAxisRaw("Horizontal");
        var v = Input.GetAxisRaw("Vertical");

        if ((h < 0 || h > 0 || v < 0 || v > 0))
        {
            isMoving = true;
            if (!GetComponent<BoxCollider2D>().IsTouchingLayers(Physics2D.AllLayers))
                lastDirection = rigd2d.velocity;
            else
                lastDirection = rigd2d.velocity;
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            MeleeAttack();
        }

        var moveVector = new Vector2(h, v);
        Movment(moveVector * playerSpeed);
        Shield();
    }

    void Movment(Vector2 moveVector)
    {
        rigd2d.velocity = Vector2.zero;
        rigd2d.AddForce(moveVector, ForceMode2D.Impulse);

        SendAnimInfo();
    }

    void SendAnimInfo()
    {
        anim.SetFloat("XSpeed", rigd2d.velocity.x);
        anim.SetFloat("YSpeed", rigd2d.velocity.y);

        anim.SetFloat("LastX", lastDirection.x);
        anim.SetFloat("LastY", lastDirection.y);

        anim.SetBool("IsMoving", isMoving);
        anim.SetBool("IsAttacking", isAttacking);
    }
    void MeleeAttack()
    {
        isMoving = false;
        isAttacking = true;
        SendAnimInfo();
    }

    void Shield()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl) && shieldAmount > 0)
        {
            playerShield.SetActive(!isShieldActive);
            isShieldActive = !isShieldActive;
        }
        else if(shieldAmount <= 0)
        {
            isShieldActive = false;
            playerShield.SetActive(isShieldActive);
        }
    }
}