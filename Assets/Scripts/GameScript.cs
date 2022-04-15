using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
	[SerializeField]
	Transform MainPanel;
	
	[SerializeField]
	Transform ToolsPanel;
	
	[SerializeField]
	Transform StorePanel;

	//[SerializeField]
	//Transform SettingsPanel;

	[SerializeField]
	Transform ChallengesPanel;

	[SerializeField]
	Text clicksText;
	
	[SerializeField]
	Text ramQtyText;
	[SerializeField]
	Text ramCostText;
	
	[SerializeField]
	Text cpuQtyText;
	[SerializeField]
	Text cpuCostText;
	
	[SerializeField]
	Text gpuQtyText;
	[SerializeField]
	Text gpuCostText;
	
	[SerializeField]
	GameObject coin;
	
	float numClicks;
	int numClicksMult;
	float randomFloat;
	int ramQty;
	int cpuQty;
	int gpuQty;
	int ramCost;
	int cpuCost;
	int gpuCost;
	
	string currPanel;
	
    // Start is called before the first frame update
    void Start()
    {
		QualitySettings.vSyncCount = 0;
		Application.targetFrameRate = 240;
		numClicks = 5000;
		numClicksMult = 1;
		
		
		currPanel = "main";
		
		ramQty = 0;
		ramCost = 100;
		cpuQty = 0;
		cpuCost = 500;
		gpuQty = 0;
		gpuCost = 1000;

		ramCostText.text = "Cost: " + getRAMCost() + " bits";
		gpuCostText.text = "Cost: " + getGPUCost() + " bits";
		cpuCostText.text = "Cost: " + getCPUCost() + " bits";



		ChallengesPanel.gameObject.SetActive(false);
        MainPanel.gameObject.SetActive(true);
		ToolsPanel.gameObject.SetActive(true);
		//SettingsPanel.gameObject.SetActive(false);
		StorePanel.gameObject.SetActive(false);
		
    }

    // Update is called once per frame
    void Update()
    {
		randomFloat = Random.Range(-2f, 2f);
        clicksText.text = ((int)numClicks) + " bits";

		if (getNumClicks() > 1000){ // temporary number, will in reality be much higher
			//change picture next to the achievement from black to a trophy
        }

		if ()


		if (getCPUQty() != 0) {
			numClicks += 0.01f * ((5* Mathf.Pow(1.8f, getCPUQty())) * Mathf.Pow(2, getGPUQty()));
		}
    }
	
	void setNumClicks(float val) {
		numClicks = val;
	}
	void setNumClicksMult(int val) {
		numClicksMult = val;
	}
	void incRAMQty () {
		ramQty++;
		setRamCost((int)(ramCost * (1.7 * Mathf.Pow(1.04f, getRAMQty()))));
		ramQtyText.text = "Qty: " + getRAMQty();
		ramCostText.text = "Cost: " + getRAMCost() + " bits";
	}
	void incGPUQty () {
		gpuQty++;
		setGPUCost((int)(gpuCost * (2 * Mathf.Pow(1.12f, getGPUQty()))));
		gpuQtyText.text = "Qty: " + getGPUQty();
		gpuCostText.text = "Cost: " + getGPUCost() + " bits";
	}
	void incCPUQty () {
		cpuQty++;
		setCPUCost((int)(cpuCost * (2 * Mathf.Pow(1.09f, getCPUQty()))));
		cpuQtyText.text = "Qty: " + getCPUQty();
		cpuCostText.text = "Cost: " + getCPUCost() + " bits";
	}
	void setRamCost(int val) {
		ramCost = val;
	}
	void setCPUCost(int val) {
		cpuCost = val;
	}
	void setGPUCost(int val) {
		gpuCost = val;
	}
	
	float getNumClicks() {
		return numClicks;
	}
	int getNumClicksMult() {
		return numClicksMult;
	}
	int getRAMQty () {
		return ramQty;
	}
	int getGPUQty () {
		return gpuQty;
	}
	int getCPUQty () {
		return cpuQty;
	}
	int getRAMCost () {
		return ramCost;
	}
	int getCPUCost () {
		return cpuCost;
	}
	int getGPUCost () {
		return gpuCost;
	}
	
	public void Click() {
		numClicks = numClicks + (1 * numClicksMult);
		Instantiate(coin, new Vector3(randomFloat, 4, 0), Quaternion.identity);
	}
	
	public void SettingsClicked() {
		
	}

	public void ChallengesClicked() {
		if (currPanel != "challenges") {
			MainPanel.gameObject.SetActive(false);
			StorePanel.gameObject.SetActive(false);
			ChallengesPanel.gameObject.SetActive(true);
			currPanel = "challenges";
        }
		else {
			ChallengesPanel.gameObject.SetActive(false);
			MainPanel.gameObject.SetActive(true);
			currPanel = "main";
        }
    }
	
	public void StoreClicked() {
		if (currPanel != "store"){
			MainPanel.gameObject.SetActive(false);
			ChallengesPanel.gameObject.SetActive(false);
			StorePanel.gameObject.SetActive(true);
			currPanel = "store";
		}
		else {
			currPanel = "main";
			StorePanel.gameObject.SetActive(false);
			MainPanel.gameObject.SetActive(true);
		}
		
	}
	
	public void PurchaseRAMModules() {
		if (numClicks >= ramCost) {
			setNumClicks(numClicks - (float)ramCost);
			setNumClicksMult(numClicksMult * 2);
			incRAMQty();
			
		}
	}
	
	public void PurchaseCPU() {
		if (numClicks >= cpuCost) {
			setNumClicks(numClicks - (float)cpuCost);
			incCPUQty();
		}
	}
	
	public void PurchaseGPU() {
		if ((numClicks >= gpuCost) && getCPUQty() > 0) {
			setNumClicks(numClicks - (float)gpuCost);
			incGPUQty();
			
		}
	}
}
