using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour
{

    public GameObject OSPanel;
    public GameObject CreditsPanel;
    public GameObject HelpPanel;
    private AudioSource ad;
    void Start()
    {
        ad = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickPlay()
    {
        ad.Play();
        SceneManager.LoadScene(1);

    }

    public void OnClickOS()
    {
        OSPanel.SetActive(true);
        ad.Play();

    }
    public void OnClickCredits()
    {
        CreditsPanel.SetActive(true);
        ad.Play();

    }
    public void OnClickHelp()
    {
        HelpPanel.SetActive(true);
        ad.Play();

    }

    public void OnClickBack()
    {
        OSPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        HelpPanel.SetActive(false);
        ad.Play();

    }

    public void OnClickScene(int i)
    {
        ad.Play();
        SceneManager.LoadScene(i);

    }


}
