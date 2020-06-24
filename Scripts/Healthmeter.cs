using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthmeter : MonoBehaviour
{
    public Text health;
    [SerializeField] Boss bosshealth;
   

    // Update is called once per frame
    void Update()
    {
        health.text = bosshealth.health.ToString() ;

    }
}
