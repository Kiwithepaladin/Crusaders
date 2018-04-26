using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTextBox : MonoBehaviour
{
    public GameObject textBox;
    private bool objectExists = false;
    GameObject temp;

    private void Update()
    {
        temp = GameObject.Find("Reaper's Letter(Clone)");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

            GameObject.Instantiate(textBox);
            objectExists = true;
          


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject.Destroy(temp);
    }
       
    
}
