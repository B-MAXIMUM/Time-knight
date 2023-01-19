using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool IsGameover = true;
    public TextMeshProUGUI GameOverText;
    public GameObject BG;
    public GameObject Playerpit;
    public GameObject Nigaman;
    public Button faggot;
    public Button Help;
    public GameObject Title;
    public float Timeramont;
    public Text Timer;
    public GameObject Camera;
    public GameObject Camera2;
    public GameObject fuckle;
    public Button QuitButt;
    public Button StartButton;
    public AudioClip Music;
    public AudioClip Vicroy;
    private AudioSource _Paud;
    // Start is called before the first frame update
    
    void Start() 
    {
        _Paud = GetComponent<AudioSource>();
        Timeramont = 0;
    }
    private void Update() 
    {
        if(IsGameover == false)
        {
            Timeramont = Timeramont + Time.deltaTime;
        }   
        TimeSpan time = TimeSpan.FromSeconds(Timeramont);
        Timer.text = time.ToString(@"mm\:ss");

    }
    public void Beaner()
    {
        _Paud.clip = Music;
        _Paud.Play();
        Title.gameObject.SetActive(false);
        StartButton.gameObject.SetActive(false);
        Playerpit.gameObject.SetActive(false);
        QuitButt.gameObject.SetActive(false);
        fuckle.gameObject.SetActive(true);
        Timer.gameObject.SetActive(true);
        Help.gameObject.SetActive(false);
        BG.gameObject.SetActive(false);
        Camera.gameObject.SetActive(false);
        Camera2.gameObject.SetActive(true);
        IsGameover = false;
    }
    public void GameOver()
    {
        _Paud.Stop();
        Timer.gameObject.SetActive(false);
        IsGameover = true;
        BG.gameObject.SetActive(true);
        faggot.gameObject.SetActive(true);
        GameOverText.gameObject.SetActive(true);
    }
    public void GameCumlord()
    {
        BG.gameObject.SetActive(true);
        IsGameover = true;
        _Paud.Stop();
        _Paud.PlayOneShot(Vicroy, 2.0f);
        faggot.gameObject.SetActive(true);
        QuitButt.gameObject.SetActive(true);
        fuckle.gameObject.SetActive(false);
        Camera2.gameObject.SetActive(false);
        Camera.gameObject.SetActive(true);
        Nigaman.gameObject.SetActive(true);
    }
    public void FuckingUrMom()
    {
        SceneManager.LoadScene(0);
    }
    public void Queer()
    {
        Application.Quit();
    }
    public void wtfGoinON()
    {
        SceneManager.LoadScene(1);
    }
}
