using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateGameCanvas : MonoBehaviour
{
    // Start is called before the first frame update

    private TextMeshProUGUI m_Text;
    private GameObject m_Rocket;
    void Start()
    {
        m_Text = GameObject.Find("/Game Canvas/Player info").GetComponent<TextMeshProUGUI>();
        m_Rocket = GameObject.Find("Rocket");
    }

    // Update is called once per frame
    void Update()
    {
        m_Text.text = $"Score : {m_Rocket.GetComponent<Score>().GetScore()}\nHealth : {m_Rocket.GetComponent<Health>().healthPoints}";
    }
}
