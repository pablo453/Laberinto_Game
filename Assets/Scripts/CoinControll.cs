using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControll : MonoBehaviour
{
    public string playerName, controlName = "GameControl";
    public float pickDistance = 0.45f;
    public int myPoints = 5;
    public bool finallCoin;
    

    private GameObject thePlayer, theControl;


    void Start()
    {
        thePlayer = GameObject.Find(playerName);
        theControl = GameObject.Find(controlName);
    }

   
    void Update()
    {
        if (Vector3.Distance(transform.position, thePlayer.transform.position) < pickDistance)
        {
            if (finallCoin) theControl.GetComponent<GameControl>().GameFinished();



            else theControl.GetComponent<GameControl>().IncreaseScore(myPoints);
            Destroy(gameObject);

        }

           


            
    }
}
