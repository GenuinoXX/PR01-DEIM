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
        while (n < 25)
        {
            n++;
            print(n);
            if (n == 25)
            {
                print(mens);
            }
        }
        for (m = 8; m <= 48; m++)
        {
            print(m);
            if (m == 48)
            {
                print(mens2);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
