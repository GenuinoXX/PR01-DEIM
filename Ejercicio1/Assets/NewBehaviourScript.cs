using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour
{
    int n = 0;
    int m = 0;
    int � = 0;
    string mens = "El bayonetta est� guapo";
    string mens2 = "Odio a Chris Pratt";
    public string nombre = "Rodolfo";
    public bool Penta = true;
    public Text timer;
    


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Contador");
    }

    IEnumerator Contador()
    {
        while (true)
        {
            print("la hora es "+ � + ":"+m+ ":" + n);
            timer.text = "la hora es " + � + ":" + m + ":" + n;
            n++;
            yield return new WaitForSeconds(1f);

            if (n == 60)
            {
                n = 0;
                m++;
            }

            if (m == 60)
            {
                m = 0;
                �++;
            }
            if (� == 1)
            {
                StopCoroutine("Contador");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
