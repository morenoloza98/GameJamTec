using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public GameObject player;
    public CharacterController2D characterScript;
    public Text fulfillmentText;
    public RawImage choco;
    public RawImage milk;
    public RawImage mmellow;
    public GameObject[] itemsTwo;

    void Update()
    {
        if (characterScript.smoreMode)
        {
            fulfillmentText.gameObject.SetActive(true);
        }

        if (characterScript.nearBear)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }

    void Hide()
    {
        if (fulfillmentText.gameObject.activeSelf)
        {
            fulfillmentText.gameObject.SetActive(false);
        }
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
