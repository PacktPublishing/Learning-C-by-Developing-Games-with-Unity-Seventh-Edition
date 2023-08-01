using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private int CurrentAge = 30;

    public int AddedAge = 1;
    public float Pi = 3.14f;
    public string FirstName = "Harrison";
    public bool IsAuthor = true;


    // Start is called before the first frame update
    void Start()
    {
        // ComputeAge();

        // Debug.Log("Text goes here.");
        // Debug.Log(CurrentAge);
        // Debug.LogFormat("Text goes here -> Current Age: {0}, Added Age: {1} are variable placeholders", CurrentAge, AddedAge);
        // Debug.Log($"A string can have variables like {FirstName} inserted directly!");

        // int MyInteger = 3;
        // float MyFloat = MyInteger;
        // int ExplicitConversion = (int)3.14;

        // Debug.Log(MyInteger);
        // Debug.Log(MyFloat);
        // Debug.Log(ExplicitConversion);

        // string FullName = "Harrison " + "Ferrone";
        // Debug.Log(FullName);
        // Debug.Log(FirstName * Pi);

        int characterLevel = 32;
        int nextSkillLevel = GenerateCharacter("Spike", characterLevel);

        Debug.Log(nextSkillLevel);
        Debug.Log(GenerateCharacter("Faye", characterLevel));
    }

    /// <summary>
    /// Computes a modified age by adding two variables together
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }

    public int GenerateCharacter(string name, int level)
    {
        // Debug.LogFormat("Character: {0} – Level: {1}", name, level);
        return level += 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}