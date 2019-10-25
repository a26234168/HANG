﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
    public Text HungerText;
    public Text FriendshipText;
    public Text isSickText;

    public
        GameObject Rock;

    // Start is called before the first frame update
    void Start()
    {
        /*HungerText.text = "I'm Hungry";
        FriendshipText.text = "Hello";
        isSickText.text = "Healthy";*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Rock != null)
        {



            HungerText.text = Rock.GetComponent<RockController>().hunger.ToString();
            FriendshipText.text = Rock.GetComponent<RockController>().friendship.ToString();
            isSickText.text = Rock.GetComponent<RockController>().isSick.ToString();
        }

    }
    public void FeedRock()
    {
        Rock.GetComponent<RockController>().hunger += 2;
    }
    public void PlayWithRock()
    {
        Rock.GetComponent<RockController>().friendship += 2;
    }
    public void Vet()
    {
        Rock.GetComponent<RockController>().isSick = false;
    }
}
