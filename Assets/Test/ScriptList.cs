using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptList : MonoBehaviour
{
    //Lista de inimigos
    //public List<string> Inimigos = new List<string>();

    [System.Serializable]
    public class Orc
    {
        public string nome;
        public string forca;
        public string dano;

    }

    //Chama uma lista de Orcs
    public List<Orc> Orcs = new List<Orc>();

/*
    void Start()
    {
        Inimigos.Add("Orc");
        Inimigos.Add("Elfo");
        Inimigos.Add("Guerreiro");
        Inimigos.Add("Arqueiro");
    }
*/
    // Update is called once per frame
    void Update()
    {
        
    }
}
