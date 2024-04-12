using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TranslationManager : MonoBehaviour
{
    public Text assignText;
    public Text catalanText;
    public Text italianoText;
    public Text francesText;
    public Text arabeText;
    public Translation[] translations;

    public void TranslateText(string language) 
    {
        foreach (Translation translation in translations)
        {
            if(translation.languageFlag == language)
            {
                assignText.text = translation.textTranslation;
                catalanText.text = translation.catalanTranslation;
                italianoText.text = translation.italianoTranslation;
                francesText.text = translation.francesTranslation;
                arabeText.text = translation.arabeTranslation;
                return; 
            }
        }
    }
}
