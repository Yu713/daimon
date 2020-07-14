using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserProfile : MonoBehaviour
{

    public SpeechInputService mySpeechInputMgr;
    public ExerciseController ExerciseController;

    // -  -  -  -  -  -  -  -  -  -  -  -  -  -

    public string Name;

    public enum gender { male, female };
    public gender Gender;
    
    public int Age;

    public double bmi;
    public int Height;
    public int Weight;

    public enum cancers
    {

    };
    public cancers CancerType;

    public enum Frequency {
        threeMonths,
        threeToSixMonths
    };
    public Frequency PhysicalExerciseFrequency;
    public Frequency ExerciseFrequency;

    public enum feelings {good, bad};
    public feelings Feeling;

    public enum TreatmentTime { };
    public TreatmentTime treated;

    public enum CVdiseases { };
    public CVdiseases CardiovascularDiseases;

    public enum pains { };
    public pains Pain;

    // -  -  -  -  -  -  -  -  -  -  -  -  -  -  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
