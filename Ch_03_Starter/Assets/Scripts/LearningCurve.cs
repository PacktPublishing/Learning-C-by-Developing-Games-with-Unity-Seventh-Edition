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
        Debug.Log(30 + 1);
        Debug.Log(CurrentAge + 1);

        ComputeAge();
    }

    /// <summary>
    /// A method to compute two variables
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }
}