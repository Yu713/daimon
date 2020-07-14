using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserProfile : MonoBehaviour
{

    public SpeechInputService mySpeechInputMgr;
    public ExerciseController ExerciseController;

    //public int age;

    public class Question
    {
        public Profiles ID { get; set; } //get read, set write
        public string Content { get; set; }
        public bool IsFreestyle { get; set; }
        public List<string> Responses { get; set; }
        public string Answer { get; set; }


    
    }



    public enum Profiles
    {
        Name,
        Gender,
        Age,
        Height,
        Weigh,
        CancerType,
        PhysicalExerciseFrequency,
        ExericseFrequency,
        Feeling,
        TreatmentTime,
        CardiovascularDiseases,
        Pain,
    }

    public class Questions
    {
     //   public bool ShouldSelect { get; set; }
        public AudioClip AudioClip { get; set; }

    }
    

	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
