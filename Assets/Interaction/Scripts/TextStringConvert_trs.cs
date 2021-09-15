/**
 * @author Ahmad Nadhif Muhajir (Teeres)
 * @version 1.0
 */
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextStringConvert_trs : MonoBehaviour
{
    public string trs_string;
    public Text trs_text;
    
    public void TextToString (Text xtext) {
        trs_string = xtext.text;
    }
    
    public void StringToText (string xstring) {
        trs_text.text = trs_string.ToString();
    }
}
