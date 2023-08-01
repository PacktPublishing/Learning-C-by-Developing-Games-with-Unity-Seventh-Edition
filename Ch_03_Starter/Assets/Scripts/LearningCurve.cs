using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int CurrentAge = 30;
    public int AddedAge = 1;

    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
    }

    /// <summary>
    /// Computes a modified age by adding two variables together
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}