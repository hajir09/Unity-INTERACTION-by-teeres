/**
 * @author Ahmad Nadhif Muhajir (Teeres)
 * @version 1.0
 */
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interaction_trs : MonoBehaviour
{
    
    public void OnOBJ (GameObject xobj) {
        xobj.SetActive(true);
    }

    public void OffOBJ (GameObject xobj) {
        xobj.SetActive(false);
    }

    public void GotoLevelWithText (Text xtext) {
        string xlevel = xtext.text;
        Debug.Log (xlevel);
        SceneManager.LoadScene (xlevel);
    }

    public void GotoLevelWithString (string xlevel) {
        SceneManager.LoadScene (xlevel);
    }
   
}
