using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using IBM.Cloud.SDK.Utilities;
using IBM.Cloud.SDK.Authentication;
using IBM.Cloud.SDK;
using IBM.Watson.LanguageTranslator.V3;
using IBM.Watson.LanguageTranslator.V3.Model;
using System;

public class LangTransService : MonoBehaviour
{

    public Text ResponseTextField; // inspector slot for drag & drop of the Canvas > Text gameobject

    private LanguageTranslatorService languageTranslatorService;

    public string translationModel = "en-de";
    public string versionDate = "2018-12-19";
    public string apiKey = "htouiGDBVSOcjKYQSwgIC71hDcxKCQMJGLDCT8mWBbJ5";
    public string serviceUrl = "https://gateway-lon.watsonplatform.net/language-translator/api";

    public string lastTranslationResult = null;

    // Start is called before the first frame update
    void Start()
    {
        LogSystem.InstallDefaultReactors();
        StartCoroutine(ConnectToTranslationService());
    }

    private IEnumerator ConnectToTranslationService()
    {
        TokenOptions languageTranslatorTokenOptions = new TokenOptions()
        {
            IamApiKey = apiKey
        };
        Credentials languageTranslatorCredentials = new Credentials(languageTranslatorTokenOptions, serviceUrl);
        while (!languageTranslatorCredentials.HasIamTokenData()) yield return null;

        languageTranslatorService = new LanguageTranslatorService(versionDate, languageTranslatorCredentials);

        //Translate("Where is the library");
    }

    //  Call this method from ExampleStreaming
    public void Translate(string text)
    {
        //  Array of text to translate
        List<string> translateText = new List<string>();
        translateText.Add(text);

        //  Call to the service
        languageTranslatorService.Translate(OnTranslate, translateText, translationModel);
    }

    //  OnTranslate handler
    private void OnTranslate(DetailedResponse<TranslationResult> response, IBMError error)
    {
        //  Populate text field with TranslationOutput
        ResponseTextField.text = response.Result.Translations[0].TranslationOutput;
        lastTranslationResult = response.Result.Translations[0].TranslationOutput;
    }

}
