using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool Gameover = false;
    public TextMeshProUGUI GameOverText;
    public GameObject canvas;
    public Button faggot;
    public GameObject Title;
    public GameObject Camera;
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
    }
}
