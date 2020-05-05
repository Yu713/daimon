using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ExerciseController : MonoBehaviour
{
    public static ExerciseController Instance;

    public List<ExerciseData> Exercises;

    private void Awake()
        {
        Instance = this;
        Exercises = new List<ExerciseData>(); //List: 当收集同一种类的多个物品时，将看到的所有物品都列出
        foreach (Exercise exercise in Enum.GetValues(typeof(Exercise)).Cast<Exercise>())
        {
            Exercises.Add(new ExerciseData(exercise));
        }
        }

    Animator m_animator;
    [SerializeField]
    GameObject m_rootGO;
    [SerializeField]
    public enum Exercise
    {
        A1BigBird,
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
        B61,
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
        BresthingIdle,
        Idle,
        Plank,
        PushUp,
        StandingIdle,
        Upright,
        Waving,
    }



    [SerializeField]
    public class ExerciseData
    {
        public Exercise Exercise;
        public string Name;
        public int AnimatorBool;
        public bool isExluded;
        public ExerciseData(Exercise exercise)
        {
            Exercise = exercise;
            isExluded = false;
        }
    }



    Dictionary<string, Exercise> Map = new Dictionary<string, Exercise> //Dictionary: 可以合并
       {
          
        
       

       }//

    void Start()
    {
        
    }

}
