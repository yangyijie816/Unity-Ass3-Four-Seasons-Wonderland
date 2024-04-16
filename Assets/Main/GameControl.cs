using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    int num = 0;
    private AudioSource ad;
    Camera mainCamera;
    Transform Player;

    bool musicBool;
    void Start()
    {
        musicBool = true;
        mainCamera = Camera.main;
        Player = GameObject.Find("Player").transform;
        ad = GetComponent<AudioSource>();

        transform.Find("MainBtn").GetComponent<Button>().onClick.AddListener(() =>
        {
            ad.Play();
            SceneManager.LoadScene(0);
        });
        Scene currentScene = SceneManager.GetActiveScene();
        transform.Find("PlayBtn").GetComponent<Button>().onClick.AddListener(() =>
        {
            ad.Play();
            switch (currentScene.name)
            {
                case "Spring":
                    Player.transform.eulerAngles = new Vector3(0, 90, 0);
                    Player.GetComponent<Player>().enabled = true;
                    mainCamera.transform.SetParent(Player);
                    mainCamera.transform.localPosition = new Vector3(0, 5.466f, -8.64f);
                    mainCamera.transform.localEulerAngles = new Vector3(12, 0, 0);

                    transform.Find("PlayBtn").gameObject.SetActive(false);
                    break;
                case "Summer":
                    Player.transform.eulerAngles = new Vector3(0, -80, 0);
                    Player.GetComponent<Player1>().enabled = true;
                    mainCamera.transform.SetParent(Player);
                    mainCamera.transform.localPosition = new Vector3(0, 3.11f, -5.12f);
                    mainCamera.transform.localEulerAngles = new Vector3(12, 0, 0);

                    transform.Find("PlayBtn").gameObject.SetActive(false);

                    break;
                case "Autumn":
                    Player.transform.eulerAngles = new Vector3(0, 180, 0);
                    Player.GetComponent<Player2>().enabled = true;
                    mainCamera.transform.SetParent(Player);
                    mainCamera.transform.localPosition = new Vector3(0, 1.36f, -2.31f);
                    mainCamera.transform.localEulerAngles = new Vector3(12, 0, 0);

                    transform.Find("PlayBtn").gameObject.SetActive(false);

                    break;
                case "Winter":
                    Player.transform.eulerAngles = new Vector3(0, 0, 0);
                    Player.GetComponent<Player3>().enabled = true;
                    mainCamera.transform.SetParent(Player);
                    mainCamera.transform.localPosition = new Vector3(0, 12f, -20f);
                    mainCamera.transform.localEulerAngles = new Vector3(12, 0, 0);

                    transform.Find("PlayBtn").gameObject.SetActive(false);

                    break;
            }
        });

        transform.Find("HelpBtn").GetComponent<Button>().onClick.AddListener(() =>
        {
            transform.Find("HelpPanel").gameObject.SetActive(true);

        });
        transform.Find("HelpPanel/CloseButton").GetComponent<Button>().onClick.AddListener(() =>
        {
            transform.Find("HelpPanel").gameObject.SetActive(false);
        });

        transform.Find("MusicBtn").GetComponent<Button>().onClick.AddListener(() =>
        {
            if (musicBool==false)
            {
                musicBool = true;
                transform.Find("MusicBtn").GetComponent<AudioSource>().Play();
                transform.Find("MusicBtn").GetComponent<Image>().color = Color.green;
            }
            else
            {
                musicBool = false;
                transform.Find("MusicBtn").GetComponent<AudioSource>().Pause();
                transform.Find("MusicBtn").GetComponent<Image>().color = Color.white;
            }
        });


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickScene(int i)
    {
        ad.Play();
        SceneManager.LoadScene(i);
    }

    public void JFadd()
    {
        num = num + 1;
        transform.Find("Integral/JF").GetComponent<Text>().text = num.ToString();


        if (num == 6)
        {
            transform.Find("Win").gameObject.SetActive(true);
        }
    }

}
