using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankSelect : MonoBehaviour
{
    public GameObject[] tank;
    public GameObject tank1;
    public GameObject tank2;
    public GameObject tank3;
    public GameObject[] menu;
    public GameManager gameManager;
    public Text player;
    [HideInInspector] public int m_PlayerNumber = 1;

    void Start()
    {
        m_PlayerNumber++;
        gameManager = GetComponent<GameManager>();
        player.text = "Player " + m_PlayerNumber;
    }

    void FixedUpdate()
    {

        if (tank[0].activeInHierarchy == false)
        {
            gameManager.m_TankPrefab.Add(tank1);
            tank[0].SetActive(true);
            if (menu[0].activeInHierarchy == false && menu[1].activeInHierarchy == true)
            {
                menu[1].SetActive(false);
            }
            if (menu[0].activeInHierarchy == false && menu[1].activeInHierarchy == false)
            {
                menu[3].SetActive(true);
                menu[4].SetActive(true);
                gameManager.enabled = true;
                Destroy(menu[0]);
                Destroy(menu[1]);
                Destroy(menu[2]);
                Destroy(menu[5]);
                Destroy(tank[0]);
                Destroy(tank[1]);
                Destroy(tank[2]);
            }

            if (menu[0].activeInHierarchy == true && menu[1].activeInHierarchy == false)
            {
                m_PlayerNumber++;
                menu[0].SetActive(false);
                menu[1].SetActive(true);
                player.text = "Player " + m_PlayerNumber ;
            }
            
        }
        if (tank[1].activeInHierarchy == false)
        {
            gameManager.m_TankPrefab.Add(tank2);
            tank[1].SetActive(true);
            if (menu[0].activeInHierarchy == false && menu[1].activeInHierarchy == true)
            {
                menu[1].SetActive(false);
            }
            if (menu[0].activeInHierarchy == false && menu[1].activeInHierarchy == false)
            {
                menu[3].SetActive(true);
                menu[4].SetActive(true);
                gameManager.enabled = true;
                Destroy(menu[0]);
                Destroy(menu[1]);
                Destroy(menu[2]);
                Destroy(menu[5]);
                Destroy(tank[0]);
                Destroy(tank[1]);
                Destroy(tank[2]);
            }

            if (menu[0].activeInHierarchy == true && menu[1].activeInHierarchy == false)
            {
                m_PlayerNumber++;
                menu[0].SetActive(false);
                menu[1].SetActive(true);
                player.text = "Player " + m_PlayerNumber;
            }


        }
        if (tank[2].activeInHierarchy == false)
        {
            gameManager.m_TankPrefab.Add(tank3);
            tank[2].SetActive(true);
            if (menu[0].activeInHierarchy == false && menu[1].activeInHierarchy == true)
            {
                menu[1].SetActive(false);
            }
            if (menu[0].activeInHierarchy == false && menu[1].activeInHierarchy == false)
            {
                menu[3].SetActive(true);
                menu[4].SetActive(true);
                gameManager.enabled = true;
                Destroy(menu[0]);
                Destroy(menu[1]);
                Destroy(menu[2]);
                Destroy(menu[5]);
                Destroy(tank[0]);
                Destroy(tank[1]);
                Destroy(tank[2]);
            }

            if (menu[0].activeInHierarchy == true && menu[1].activeInHierarchy == false)
            {
                m_PlayerNumber++;
                menu[0].SetActive(false);
                menu[1].SetActive(true);
                player.text = "Player " + m_PlayerNumber;
            }

        }
    }
}
