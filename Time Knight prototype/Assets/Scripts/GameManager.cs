using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool IsGameover = true;
    public TextMeshProUGUI GameOverText;
    public GameObject canvas;
    public GameObject Nigaman;
    public Text Timer;
    public Button faggot;
    public Button Help;
    public GameObject Title;
    public GameObject Camera;
    public GameObject Camera2;
    public GameObject fuckle;
    public Button QuitButt;
    public Button StartButton;
    public AudioClip Music;
    private AudioSource _Paud;
    // Start is called before the first frame update
    
    void Start() 
    {
        _Paud = GetComponent<AudioSource>();
    }
    public void Beaner()
    {
        _Paud.clip = Music;
        _Paud.Play();
        StartButton.gameObject.SetActive(false);
        Timer.text.SetActive(true);
        Timer.text = + spanTime.Minutes+ " : " + spanTime.Seconds;
        QuitButt.gameObject.SetActive(false);
        fuckle.gameObject.SetActive(true);
        Help.gameObject.SetActive(false);
        canvas.gameObject.SetActive(false);
        Camera.gameObject.SetActive(false);
        Camera2.gameObject.SetActive(true);
        IsGameover = false;
    }
    private void Update() 
    {

    }
    public void GameOver()
    {
        _Paud.Stop();
        IsGameover = true;
        canvas.gameObject.SetActive(true);
        faggot.gameObject.SetActive(true);
        Timer.gameObject.SetActive(false);
        GameOverText.gameObject.SetActive(true);
    }
    public void GameCumlord()
    {
        canvas.gameObject.SetActive(true);
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
