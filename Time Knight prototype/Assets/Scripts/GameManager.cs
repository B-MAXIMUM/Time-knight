using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI GameOverText;
    public Button faggot;
    public GameObject Camera;
    public GameObject fuckle;
    public Button QuitButt;
    public GameObject StartButtons;
    // Start is called before the first frame update
    public void Beaner()
    {
        StartButtons.gameObject.SetActive(false);
        QuitButt.gameObject.SetActive(false);
        fuckle.gameObject.SetActive(true);
        

    }
}
