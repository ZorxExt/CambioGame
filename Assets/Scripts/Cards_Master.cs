using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards_Master : MonoBehaviour
{
    public Dictionary<string, Vector2Int> card_deck = new Dictionary<string, Vector2Int>();

    public Vector2Int player_card1b;
    public Vector2Int player_card2b;
    public Vector2Int player_card3b;
    public GameObject vanilla_card;
    private GameObject _player_card1;
    private GameObject _player_card2;
    private GameObject _player_card3;

    void Start()
    {
        Shuffle_player();
    }

    public void Create_Deck()
    {
        for (int x = 1; x < 5; x++)
        {
            for (int i = 1; i < 13; i++)
            {
                card_deck.Add();
            }
        }
    }
    

    public void Shuffle_player()
    {
        player_card1b.x = Random.Range(1, 4);
        player_card1b.y = Random.Range(1, 12);
        player_card2b.x = Random.Range(1, 4);
        player_card2b.y = Random.Range(1, 12);
        player_card3b.x = Random.Range(1, 4);
        player_card3b.y = Random.Range(1, 12);

        _player_card1 = Instantiate(vanilla_card, new Vector3(0, 0, 0), Quaternion.identity);
        _player_card1.GetComponent<Card_Controller>().color_input = player_card1b.x;
        _player_card1.GetComponent<Card_Controller>().number_input = player_card1b.y;

        _player_card2 = Instantiate(vanilla_card, new Vector3(0, 0, 1.5f), Quaternion.identity);
        _player_card2.GetComponent<Card_Controller>().color_input = player_card2b.x;
        _player_card2.GetComponent<Card_Controller>().number_input = player_card2b.y;

        _player_card3 = Instantiate(vanilla_card, new Vector3(0, 0, -1.5f), Quaternion.identity);
        _player_card3.GetComponent<Card_Controller>().color_input = player_card3b.x;
        _player_card3.GetComponent<Card_Controller>().number_input = player_card3b.y;
    }
    
    
    
}
