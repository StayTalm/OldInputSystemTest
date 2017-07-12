using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class InputReporter : MonoBehaviour
{
    public Text textScript;

    [Serializable]
    public struct InputElement
    {
		public enum ElementType
		{
			Axis,
			Button
		}

        public string Name;
        public string IdName;
		public ElementType elementType;

    }

    public List<InputElement> inputElements = new List<InputElement>();

    public void Update()
    {
		StringBuilder sb = new StringBuilder ("CurrentInputState:\n");
		for (int i = 0; i < inputElements.Count; i++) 
		{
			InputElement element = inputElements [i];
			sb.Append (element.Name);
			sb.Append (" : ");
			switch (element.elementType) 
			{
			case InputElement.ElementType.Axis:
				{
					sb.Append (Input.GetAxis (element.Name));
				}
				break;
			case InputElement.ElementType.Button:
				{
					sb.Append(Input.GetButton(element.IdName));
				}
				break;
			}

			sb.Append ("\n");

		}

		if (textScript != null) 
		{
			textScript.text = sb.ToString ();
		}
    }
}
