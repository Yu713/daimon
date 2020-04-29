# DAIMON: Dialogue-oriented Artificial Intelligence deMONstrator

DAIMON is a demonstrator for holographic AIs written by Xinyu Huang and Prof Dr Fridolin Wild.

## IBM Watson installation

We have left the Watson version we used in the source tree. The IBM Watson Unity SDK and the IBM Unity SDK core both come under an Apache 2.0 open source license which allows that. 

Should you ever have to update to a newer version, you would download the latest IBM Watson Unity SDK release from [here](https://github.com/watson-developer-cloud/unity-sdk) and the IBM Unity SDK core from [there](https://github.com/IBM/unity-sdk-core), and follow their installation instruction (basically moving it to the Assets folder).

## IBM Watson configuration

DAIMON uses IBM Watson, so you have to register a free IBM cloud account and instantiate the services for:

* Speech to Text
* Text to Speech
* Watson Assistant
* language-translator-unity-demo (optional)

Then you have to create a file named "ibm-credentials.env" in the root folder of the project,
adding all your IBM Watson credentials. The file is in the .gitignore, so will not be syndicated
with the source tree.

This will look something like:

```
TONE_ANALYZER_APIKEY=xxx
TONE_ANALYZER_IAM_APIKEY=xxx
TONE_ANALYZER_URL=https://gateway-lon.watsonplatform.net/tone-analyzer/api
TONE_ANALYZER_AUTH_TYPE=iam
ASSISTANT_APIKEY=yyy
ASSISTANT_IAM_APIKEY=yyy
ASSISTANT_URL=https://gateway-lon.watsonplatform.net/assistant/api
ASSISTANT_AUTH_TYPE=iam
SPEECH_TO_TEXT_APIKEY=zzz
SPEECH_TO_TEXT_IAM_APIKEY=zzz
SPEECH_TO_TEXT_URL=https://gateway-lon.watsonplatform.net/speech-to-text/api
SPEECH_TO_TEXT_AUTH_TYPE=iam
TEXT_TO_SPEECH_APIKEY=uuu
TEXT_TO_SPEECH_IAM_APIKEY=uuu
TEXT_TO_SPEECH_URL=https://gateway-lon.watsonplatform.net/text-to-speech/api
TEXT_TO_SPEECH_AUTH_TYPE=iam
LANGUAGE_TRANSLATOR_APIKEY=mmm
LANGUAGE_TRANSLATOR_IAM_APIKEY=mmm
LANGUAGE_TRANSLATOR_URL=https://gateway-lon.watsonplatform.net/language-translator/api
LANGUAGE_TRANSLATOR_AUTH_TYPE=iam
```


