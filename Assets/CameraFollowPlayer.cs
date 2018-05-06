using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraFollowPlayer : MonoBehaviour
{

    public GameObject player;       


    private Vector3 padding;        

    void Start()
    {
        padding = transform.position - player.transform.position;
    }

    void Update()
    {
        transform.position = player.transform.position + padding;
    }
}