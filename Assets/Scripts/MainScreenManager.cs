using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScreenManager : MonoBehaviour
{
	[SerializeField]
	Transform MainPanel;
	
	[SerializeField]
	Transform ToolsPanel;
	
	[SerializeField]
	Text clicksText;
	
	int numClicks;
	
    // Start is called before the first frame update
    void Start()
    {
		numClicks = 0;
        MainPanel.gameObject.SetActive(true);
		ToolsPanel.gameObject.SetActive(true);
		
    }

    // Update is called once per frame
    void Update()
    {
        clicksText.text = numClicks + " bits";
    }
	
	public void Click() {
		numClicks++;
	}
}
