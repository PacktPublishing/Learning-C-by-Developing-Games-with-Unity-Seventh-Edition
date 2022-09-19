using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IManager
{
    string State { get; set; }
    void Initialize();
}