using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class SpeechRecognitionEngine : MonoBehaviour
{
   
    public string[] keywords = new string[] { "up", "down", "left", "right" };
    public ConfidenceLevel confidence = ConfidenceLevel.Medium;
    //public float speed = 1;

    public Text results;
    public Image target;

    protected PhraseRecognizer recognizer;
    protected string word;



    private void Start()
    {
        target.fillAmount = 0;
        if (keywords != null)
        {
            recognizer = new KeywordRecognizer(keywords, confidence);
            recognizer.OnPhraseRecognized += Recognizer_OnPhraseRecognized;
            recognizer.Start();
        }
    }

    private void Recognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        word = args.text;
        results.text = "You said: <b>" + word + "</b>";
        Fillamount();
    }

    private void Update()
    {
        /*var x = target.transform.position.x;
        var y = target.transform.position.y;*/



        //target.transform.position = new Vector3(x, y, 0);
    }

    private void Fillamount()
    {
        switch (word)
        {
            case "up":
                //y += speed;
                target.fillAmount += 0.1f;
                
                break;

            case "down":
                //y -= speed;
                target.fillAmount -= 0.1f;
                break;
                /*case "left":
                    x -= speed;
                    break;
                case "right":
                    x += speed;
                    break;*/
        }
    }

    private void OnApplicationQuit()
    {
        if (recognizer != null && recognizer.IsRunning)
        {
            recognizer.OnPhraseRecognized -= Recognizer_OnPhraseRecognized;
            recognizer.Stop();
        }
    }
}
