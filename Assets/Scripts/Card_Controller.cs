using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Card_Controller : MonoBehaviour
{
    public int color_input;
    public int number_input;
    public TextMeshPro number;

    public Material red_card;
    public Material blue_card;
    public Material yellow_card;
    public Material green_card;
    void Start()
    {
        switch (color_input)
        {
            case 1:
                this.GetComponent<Renderer>().material = red_card;
                break;
            case 2:
                this.GetComponent<Renderer>().material = blue_card;
                break;
            case 3:
                this.GetComponent<Renderer>().material = yellow_card;
                break;
            case 4:
                this.GetComponent<Renderer>().material = green_card;
                break;
        }
        number.text = number_input.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
