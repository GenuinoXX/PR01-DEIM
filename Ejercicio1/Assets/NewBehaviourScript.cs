using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int n = 5;
    int m = 8;
    string mens = "El bayonetta está guapo";
    string mens2 = "Odio a Chris Pratt";
    public string nombre = "Rodolfo";
    public bool Penta = true;

    void Saludo (string hola)
    {
        print("hola " + hola);
    }


    // Start is called before the first frame update
    void Start()
    {
        Saludo("Pepito");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
