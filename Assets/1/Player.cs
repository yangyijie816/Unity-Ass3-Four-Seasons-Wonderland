using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float Speed = 30f;
    public float Speed2 = 70f;
    Animator ani;

    public GameControl GC;

    void Start()
    {
        

        ani = transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed);
            ani.Play("Walk");
         
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * Speed);
            ani.Play("Walk");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-transform.up * Time.deltaTime * Speed2);
            ani.Play("Walk");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(transform.up * Time.deltaTime * Speed2);
            ani.Play("Walk");
        }

      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Coin")
        {
            Destroy(other.gameObject);

            GC.JFadd();
        }
    }



}
