using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenTextBox : MonoBehaviour
{
    public GameObject textBox;
    public GameObject guidanceText;
    private bool isExist = false;
    GameObject temp;

    private void Update()
    {
        temp = GameObject.Find("Reaper's Letter(Clone)");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        guidanceText.SetActive(true);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (!isExist && Input.GetKeyDown(KeyCode.F))
        {
            isExist = true;
            GameObject.Instantiate(textBox);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        guidanceText.SetActive(false);
        GameObject.Destroy(temp);
        isExist = false;
    }
       
    
}
