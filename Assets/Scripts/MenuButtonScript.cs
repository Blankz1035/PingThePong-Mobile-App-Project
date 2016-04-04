using UnityEngine;
using System.Collections;

public class MenuButtonScript : MonoBehaviour {
	
	public void OnClicked()
	{
		Application.LoadLevel ("Scene1");
	}

    public void OnHelpClicked()
    {
        Application.LoadLevel("HelpScene");
    }
}