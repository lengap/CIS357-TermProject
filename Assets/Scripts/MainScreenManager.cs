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
	
	[SerializeField]
	GameObject coin;
	
	int numClicks;
	float randomFloat;
	
    // Start is called before the first frame update
    void Start()
    {
		QualitySettings.vSyncCount = 0;
		Application.targetFrameRate = 240;
		numClicks = 0;
        MainPanel.gameObject.SetActive(true);
		ToolsPanel.gameObject.SetActive(true);
		
    }

    // Update is called once per frame
    void Update()
    {
		randomFloat = Random.Range(-2f, 2f);
        clicksText.text = numClicks + " bits";
    }
	
	public void Click() {
		numClicks++;
		Instantiate(coin, new Vector3(randomFloat, 4, 0), Quaternion.identity);
	}
}
