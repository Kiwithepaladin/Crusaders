using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    Animator myanim;
    void Start()
    {
        myanim = GetComponent<Animator>();
    }
    void Update()
    {
        //Right
        if (Input.GetAxisRaw("Horizontal") > 0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            myanim.SetTrigger("Walking_Left");
            //myanim.SetBool("Walking_Right", true);
            //myanim.SetBool("Walking_Down", false);
            //myanim.SetBool("Walking_Left", false);
            //myanim.SetBool("Walking_Up", false);
        }

        //Left
        if(Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
        }

        //Down
        if(Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
        }

        //Top
        if (Input.GetAxisRaw("Vertical") > 0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
           
        }

        
    }

    //private void OnTriggerStay2D(Collider2D collision)
    //{
    //    if(collision.gameObject.tag == "Player")
    //    {
    //        damageOverTime -= Time.deltaTime;
    //        if(damageOverTime <= 0)
    //        {
    //            collision.gameObject.GetComponent<Health>().health -= 1;
    //            damageOverTime = 1f;
    //        }
    //    }
    //}
}