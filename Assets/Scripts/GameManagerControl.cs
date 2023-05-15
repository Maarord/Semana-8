using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerControl : MonoBehaviour
{
    public Text Points;
    public Text Mone;
    /*public Text Bal;*/
    public int Life  = 2;
    public int moneda = 5;
    /*public int bala =5;*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void lifePersonaje (){
      Life -= 1;
      Points.text= "VIDAS :" + Life;
     }

     public void monePersonaje ()
     {
        moneda += 1;
        Mone.text= "BALAS :" + moneda;
     }

     

    
}
