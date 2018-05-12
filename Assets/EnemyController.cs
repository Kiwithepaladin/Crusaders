using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float enemyHealth;
    public float enemyDamage;
    public float enemySpeed;
    private Rigidbody2D enemyRigid2D;
    private GameObject player;


    void Start ()
    {
        enemyRigid2D = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Maya");
	}
	

	void Update ()
    {

    }

    void EnemyMovment()
    {
       transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.transform.position.x + 1, player.transform.position.y + 1),
           enemySpeed * Time.deltaTime);
    }

    void DealDamage()
    {

    }

    void SendAnimInfo()
    {
        //For Later Use
        //anim.SetFloat("XSpeed", rigd2d.velocity.x);
        //anim.SetFloat("YSpeed", rigd2d.velocity.y);

        //anim.SetFloat("LastX", lastDirection.x);
        //anim.SetFloat("LastY", lastDirection.y);

        //anim.SetBool("IsMoving", isMoving);
        //anim.SetBool("IsAttacking", isAttacking);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        InvokeRepeating("EnemyMovment", 0.5f, 0.1f);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        CancelInvoke("EnemyMovment");
    }
}
