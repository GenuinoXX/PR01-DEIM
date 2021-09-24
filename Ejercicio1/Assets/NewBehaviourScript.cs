using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int n = 5;
    int m = 8;
    string mens = "El bayonetta está guapo";
    string mens2 = "Odio a Chris Pratt";


    // Start is called before the first frame update
    void Start()
    {
       while (n != 12)
        {
            n = Random.Range(-450, 538);
            print(n);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
