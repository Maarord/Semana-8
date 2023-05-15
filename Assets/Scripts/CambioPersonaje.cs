using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioPersonaje : MonoBehaviour
{
    SpriteRenderer sr;

    public Manager2 maner ;
    
    //public GameManagerController gamemamanagercontroler;

    public Sprite Char1;
    public Sprite Char2;
    int cambio = 0;

    void Start()
    {
       sr = GetComponent<SpriteRenderer>();
       maner = FindObjectOfType <Manager2>();

    }
    // Update is called once per frame
    public void cambiopersonaje (){
        if (cambio == 0) {
            sr.sprite = Char1;
            cambio = 1;
        }
        else {
            sr.sprite = Char2;
            cambio = 0;
        }
        
    }
    public void cambioScena(){
        //SceneManagement.LoadScene(1);
        maner.persona = cambio;

        maner.SaveGame();
        
        SceneManager.LoadScene(1);

   }
   //public void selcpers () {

   //}


}
