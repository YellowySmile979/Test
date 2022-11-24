using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gay : MonoBehaviour
{
    //this is test ur mom is gay
    public float jumpSpeed = 7;
    public float moveSpeed = 5;

    Rigidbody2D rb;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
