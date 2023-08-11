using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Money4 : MonoBehaviour
{
    [SerializeField] private Text textMoney;
    private int countMoney;


    private void OnTriggerEnter(Collider other)
    {

        countMoney++;
        textMoney.text = "Money: " + countMoney.ToString() + "/10";
        Destroy(other.gameObject);
    }

    void Update()
    {
        if (countMoney == 10)
        {
            countMoney = 0;
            SceneManager.LoadScene(7);
        }
    }
}