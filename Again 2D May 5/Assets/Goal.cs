using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal, isPlayer2Goal;

    public bool EndGame;

    public int CountNum;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (isPlayer1Goal)
            {
            
                GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();
            }
            else if(isPlayer2Goal)
            {
             
                GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
            }
          
           
        }

    }
}  