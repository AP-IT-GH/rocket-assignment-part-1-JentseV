using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LandingControl : MonoBehaviour
{
    // Start is called before the first frame update

    Scene m_level;
    MyGameManager GameManager;
    void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<MyGameManager>();
        m_level = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "rocket" && m_level.name == "Level1"){
            SceneManager.LoadScene("Level2");
        }else if(other.gameObject.tag == "rocket" && m_level.name == "Level2" && GameManager != null){
            GameManager.GameState = MyGameManager.GameStates.Victory;
        }
    }
}
