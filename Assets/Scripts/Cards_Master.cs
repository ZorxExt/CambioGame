using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards_Master : MonoBehaviour
{
    public Vector2 player_card1;
    public Vector2 player_card2;
    public Vector2 player_card3;
    public object vanilla_card;
    void Start()
    {
        player_card1.x = Random.Range(1, 4);
        player_card1.y = Random.Range(1, 12);
        player_card2.x = Random.Range(1, 4);
        player_card2.y = Random.Range(1, 12);
        player_card3.x = Random.Range(1, 4);
        player_card3.y = Random.Range(1, 12);
    }


    void Update()
    {
        
    }
}
