using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject player;
    public CharacterController2D characterScript;
    public Text fulfillmentText;

    void Update()
    {
        if (characterScript.smoreMode)
        {
            fulfillmentText.gameObject.SetActive(true);
        }

        if (characterScript.nearBear)
        {
            fulfillmentText.text = "You have fulfilled your destiny!";
            fulfillmentText.gameObject.SetActive(true);
        }
    }
}
