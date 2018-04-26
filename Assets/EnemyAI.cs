using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{


    public float health;
    public float damage;
    private Color damagedColor = new Color(255.000f, 47.000f, 47.000f);
    private SpriteRenderer sp;

    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Debug.Log(Application.targetFrameRate);
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private IEnumerator Waiter()
    {
        yield return new WaitForSeconds(0.5f);

        sp.color = new Color(1.000f, 1.000f, 1.000f);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            //ProjectileBehaviour projBehaviour = collision.gameObject.GetComponent<ProjectileBehaviour>();
            //health -= projBehaviour.damage;
            //sp.color = damagedColor;
            //Destroy(projBehaviour.gameObject);
            //StartCoroutine(Waiter());

        }
    }
}