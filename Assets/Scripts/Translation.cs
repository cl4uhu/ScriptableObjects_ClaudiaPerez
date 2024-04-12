using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Translation", menuName = "Translation")]
public class Translation : ScriptableObject
{
    public string languageFlag;
    public string textTranslation;
    public string catalanTranslation; 
    public string italianoTranslation;
    public string francesTranslation;
    public string arabeTranslation;
}
