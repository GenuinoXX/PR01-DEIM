using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int NumEnt = 5;
    public int NumEnt2 = 10;
    public float NumDem = 4.25f;
    public float NumDem2 = 3.50f;
    public bool Bool = true;
    public string Cadena = "Tu me dejaste de querer cuando te necesitaaaba";
    public string Cadena2 = "Cuando más te queríiiiiiia";

    // Start is called before the first frame update
    void Start()
    {
        print(NumEnt + NumEnt2);
        print(NumDem + NumDem2);
        print(Bool);
        print(Cadena + " " + Cadena2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
