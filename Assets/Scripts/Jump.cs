using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
   // [Header("settings")] - ????????? ? ???????????

    [SerializeField]
    private Vector2 jumpForce;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
            GetComponent<AudioSource>().Play();
        } 
    }
}
