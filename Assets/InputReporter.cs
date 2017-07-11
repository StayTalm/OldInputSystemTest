using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputReporter : MonoBehaviour
{
    public Text textScript;

    [Serializable]
    public struct InputElement
    {
        public string Name;
        public string IdName;
    }

    public List<InputElement> inputElements = new List<InputElement>();

    public void Update()
    {
        StringBuilder sb = new StringBuilder();
    }
}
