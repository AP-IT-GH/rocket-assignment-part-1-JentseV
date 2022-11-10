using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    public enum GameStates{
        Playing,
        GameOver
    }


    // Start is called before the first frame update
    public GameObject Rocket;
    public GameObject MainCanvas;
    public GameObject GameOverCanvas;
    public GameStates GameState = GameStates.Playing;

    private Health rocketHealth;
    void Start()
    {
        Rocket = (Rocket == null ) ? GameObject.Find("Rocket") : Rocket;
        rocketHealth = Rocket.GetComponent<Health>();
        MainCanvas = GameObject.Find("Game Canvas");
        GameOverCanvas = GameObject.Find("GameOver Canvas");
        GameOverCanvas.SetActive(false);
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
        }
    }
}
