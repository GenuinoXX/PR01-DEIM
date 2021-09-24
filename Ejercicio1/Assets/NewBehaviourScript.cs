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

    int multiplicar (int n , int m)
    {
        int resultado = n * m;
        return resultado;
    }


    // Start is called before the first frame update
    void Start()
    {
        int resultado = multiplicar(5, 8);
        print(resultado);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
