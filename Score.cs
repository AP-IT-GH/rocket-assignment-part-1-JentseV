using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int m_score=0;
    
    public void AddPoint(int amount){
        m_score+=amount;
    }

    public int GetScore(){
        return m_score;
    }
}
