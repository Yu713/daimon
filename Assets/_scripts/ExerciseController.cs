using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ExerciseController : MonoBehaviour
{

    public UserProfile UserProfile; //data from users

    //public static ExerciseController Instance;
   // public List<ExerciseGen>; 
    

    private enum ExerciseOutputs //list all exercises
    {
        A1,
        A14,
        A15,
        A21,
        B,
        B11,
        B12,
        B13,
        B14STS,
        B22,
        B32,
        B33,
        B41,
        B41Y,
        B42,
        B51,
        B51CircleCrunch,
        B52,
        B62,
        B72,
        B82JumpingJacks,
        B83,
        B86,
        B1230,
        B4260,
        B7230,
        B8330,
        B8630,
        B62120,
        Plank,
        PushUp,
    }

   //weight (Obese) delete A3.1 B8.1 B8.2,B8.4, C1.1 in S1



    public void Sections() //S1 S2 S3
    {


    }

    public List<string> Exercises;
    public void Reset()
    {
        Exercises.Clear();
        Exercises.Add("A1");
        Exercises.Add("A14");
        Exercises.Add("A15");
        Exercises.Add("A21");
        Exercises.Add("B");
        Exercises.Add("B11");
        Exercises.Add("B12");
        Exercises.Add("B13");
        Exercises.Add("B14STS");
        Exercises.Add("B22");
        Exercises.Add("B32");
        Exercises.Add("B33");
        Exercises.Add("B41");
        Exercises.Add("B41Y");
        Exercises.Add("B42");
        Exercises.Add("B51");
        Exercises.Add("B51CircleCrunch");
        Exercises.Add("B52");
        Exercises.Add("B61");
        Exercises.Add("B62");
        Exercises.Add("B72");
        Exercises.Add("B82JumpingJacks");
        Exercises.Add("B83");
        Exercises.Add("B86");
        Exercises.Add("B1230");
        Exercises.Add("B4260");
        Exercises.Add("B7230");
        Exercises.Add("B8330");
        Exercises.Add("B8630");
        Exercises.Add("B62120");
        Exercises.Add("Plank");
        Exercises.Add("PushUp");
        Exercises.Add("Upright");
    }

    public List<ExerciseOutputs> ExcludeExercises(UserProfile questions)
    {
        switch (UserProfile)
        {
            case UserProfile.Name:
                break;
            case UserProfile.Gender:
                break;
            case UserProfile.Age:
                break;
            case UserProfile.weigh:
                {
                    if£¨UserProfiles£©{

                    }
                }



        }
    }
   

        
     }


    

    
    
  

    void Start()
    {
        Reset();
       

    }
	
	void Remove(string what){
		Exercises.Remove(what);
	}

}
