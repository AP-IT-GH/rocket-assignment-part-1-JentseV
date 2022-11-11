using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyGameManager : MonoBehaviour
{
    public enum GameStates{
        Playing,
        GameOver,
        Victory
    }

    public GameObject Rocket;
    public GameObject MainCanvas;
    public GameObject GameOverCanvas;
    public GameStates GameState = GameStates.Playing;
    private Health rocketHealth;

    private TextMeshProUGUI m_Text;
    void Start()
    {
        Rocket = (Rocket == null ) ? GameObject.Find("Rocket") : Rocket;
        rocketHealth = Rocket.GetComponent<Health>();
        MainCanvas = GameObject.Find("Game Canvas");
        GameOverCanvas = GameObject.Find("/GameOver Canvas");
        GameOverCanvas.SetActive(false);
        m_Text = GameOverCanvas.transform.Find("Message").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!rocketHealth.isAlive){
            GameState = GameStates.GameOver;
        }

        switch(GameState){
            case GameStates.GameOver: {
                MainCanvas.SetActive(false);
                GameOverCanvas.SetActive(true);
                break;
            }

            case GameStates.Victory: {
                MainCanvas.SetActive(false);
                m_Text.text = $" Victory! \n Score: {Rocket.GetComponent<Score>().GetScore()}";
                GameOverCanvas.SetActive(true);
                break;
            }
        }
    }

}
