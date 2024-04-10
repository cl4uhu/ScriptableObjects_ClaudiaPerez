using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TranslationManager : MonoBehaviour
{
    public Text assignText;
    public Translation[] translations;

    public void TranslateText(string language) 
    {
        foreach (Translation translation in translations)
        {
            if(translation.languageFlag == language)
            {
                assignText.text = translation.textTranslation;
                return; 
            }

        }
    }

}
