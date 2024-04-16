using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2 : MonoBehaviour
{
    public float Speed = 30f;
    public float Speed2 = 70f;
    Animator ani;

    public GameControl GC;

    public GameObject FlyBtn;
    bool fly;
    void Start()
    {


        ani = transform.GetComponent<Animator>();

        fly = false;
    

        FlyBtn.transform.GetComponent<Button>().onClick.AddListener(() =>
        {

            if (fly == false)
            {
                fly = true;
                FlyBtn.transform.GetComponent<Image>().color = Color.green;
            }
            else
            {
                if (transform.position.y < 0.1)
                {
                    fly = false;
                    FlyBtn.transform.GetComponent<Image>().color = Color.white;
                }

            }
        });
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed);
            if (fly)
            {
                ani.Play("Fly");
            }
            else
            {
                ani.Play("Walk");
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * Speed);
            if (fly)
            {
                ani.Play("Fly");
            }
            else
            {
                ani.Play("Walk");
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-transform.up * Time.deltaTime * Speed2);
            if (fly)
            {
                ani.Play("Fly");
            }
            else
            {
                ani.Play("Walk");
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(transform.up * Time.deltaTime * Speed2);
            if (fly)
            {
                ani.Play("Fly");
            }
            else
            {
                ani.Play("Walk");
            }

        }

        if (Input.GetKey(KeyCode.W) && transform.position.y < 10 && fly == true)
        {
            transform.Translate(Vector3.up * Time.deltaTime * Speed);
            ani.Play("Fly");
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y >= 0.1f && fly == true)
        {
            transform.Translate(-Vector3.up * Time.deltaTime * Speed);

            ani.Play("Fly");
        }







    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            Destroy(other.gameObject);

            GC.JFadd();
        }
    }



}
