using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptArray : MonoBehaviour
{
    int Moedas = 100;
    // Start is called before the first frame update
    void Start()
    {
        do
    {
        Debug.Log("Sua quantidade de moedas é: "+ Moedas);
        Moedas += 100;
    }while(Moedas < 1000);

        /*
        while (Moedas < 1000){
            Debug.Log("Sua quantidade de moedas é: "+ Moedas);
            Moedas += 100;
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
