using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    Animator myanim;
    SpriteRenderer sp;
    void Start()
    {
        myanim = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        //Right
        if (Input.GetAxisRaw("Horizontal") > 0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            myanim.SetTrigger("Walking_Right");
            sp.flipX = false;
        }

        //Left
        if(Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            myanim.SetTrigger("Walking_Left");
            sp.flipX = true;

        }

        //Down
        if(Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            myanim.SetTrigger("Walking_Down");
            sp.flipX = false;
        }

        //Up
        if (Input.GetAxisRaw("Vertical") > 0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            myanim.SetTrigger("Walking_Up");
            sp.flipX = false;
        }

        
    }
}