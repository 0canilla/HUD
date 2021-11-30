using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDcontroller : MonoBehaviour
{
    [SerializeField] public Text Hp;
    [SerializeField] public Text Sta;
    [SerializeField] private bool loseStamina;
    [SerializeField] private bool loseHealth;
    private float totalSta = 100;
    private float totalHP = 100;
    private GameObject player;
    private GameObject totem;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        totem = GameObject.Find("Totem");
    }

    // Update is called once per frame
    void Update()
    {
        Stamina();
        Health();
    }

    private void Stamina()
    {
        loseStamina = player.GetComponent<PlayerController>().sprint;
        if (loseStamina == true || totalSta >= 0)
        {
            Sta.text = "Sta" + (totalSta - 5);
        }
        if (loseStamina == false || totalSta <= 100)
        {
            Sta.text = "Sta" + (totalSta + Time.deltaTime);
        }
    }

    private void Health()
    {
        loseHealth = totem.GetComponent<TotemController>().damage;
        if (loseHealth == true)
        {
            Hp.text = "HP" + (totalHP - 5);
        }
    }

    public void Fast()
    {
        Debug.Log("Hold Shift for Speed");
    }
}
