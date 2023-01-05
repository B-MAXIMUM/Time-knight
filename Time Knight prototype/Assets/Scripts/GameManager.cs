using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool IsGameover = false;
    public TextMeshProUGUI GameOverText;
    public GameObject canvas;
    public GameObject Nigaman;
    public Button faggot;
    public GameObject Title;
    public GameObject Camera;
    public GameObject Camera2;
    public GameObject fuckle;
    public Button QuitButt;
    public Button StartButton;
    // Start is called before the first frame update
    public void Beaner()
    {
        StartButton.gameObject.SetActive(false);
        QuitButt.gameObject.SetActive(false);
        fuckle.gameObject.SetActive(true);
        canvas.gameObject.SetActive(false);
        Camera.gameObject.SetActive(false);
        Camera2.gameObject.SetActive(true);
    }
    private void Update() 
    {
    
    }
    public void GameOver()
    {
        IsGameover = true;
        canvas.gameObject.SetActive(true);
        faggot.gameObject.SetActive(true);
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
}
