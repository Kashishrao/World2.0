using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    private GameObject Robot; 
    

    private float xaxis;
    private float yaxis;
    public float speed;
    public Animator anim;
    public Animator ani;
   

    // Use this for initialization
    void Start()
    {
        //anim = GetComponent<Animator>();
        //anim.SetFloat("y", 0f);
        //anim.SetFloat("x", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        //xaxis = Input.GetAxis("Horizontal");
        //yaxis = Input.GetAxis("Vertical");


        Robot = GameObject.FindGameObjectWithTag("Player");
        //Robot.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 0f, 0f);
        //anim.SetFloat("x", xaxis);
        //anim.SetFloat("y", yaxis);

        //if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        //{
        //    Robot.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, speed, 0f);
        //}
        
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Robot.GetComponent<Rigidbody2D>().velocity = new Vector3(speed, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Robot.GetComponent<Rigidbody2D>().velocity = new Vector3(-speed, 0f, 0f);
        }

    }

   
    
}
