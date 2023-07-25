using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    [SerializeField] private Text textMoney;
    public int countMoney;



    private void OnTriggerEnter(Collider other)
    {

        countMoney++;
        textMoney.text = "Money: " + countMoney.ToString();
        Destroy(other.gameObject);
    }

   
}
