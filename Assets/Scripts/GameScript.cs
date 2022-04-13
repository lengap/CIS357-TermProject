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
		numClicks = 0;
		numClicksMult = 1;
		
		
		currPanel = "main";
		
		ramQty = 0;
		ramCost = 100;
		cpuQty = 0;
		cpuCost = 500;
		gpuQty = 0;
		gpuCost = 1000;
		
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
		ramQtyText.text = "Qty: " + getRAMQty();
		ramCostText.text = "Cost: " + getRAMCost() + " bits";
		
		cpuQtyText.text = "Qty: " + getCPUQty();
		cpuCostText.text = "Cost: " + getCPUCost() + " bits";
		
		gpuQtyText.text = "Qty: " + getGPUQty();
		gpuCostText.text = "Cost: " + getGPUCost() + " bits";
		
		if(getCPUQty() > 0) {
			numClicks += 0.01f * Mathf.Pow(10, getGPUQty());
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
	}
	void incGPUQty () {
		gpuQty++;
	}
	void incCPUQty () {
		cpuQty++;
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
	
	public void StoreClicked() {
		if (currPanel != "store"){
			MainPanel.gameObject.SetActive(false);
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
			setRamCost(ramCost * 10);
		}
	}
	
	public void PurchaseCPU() {
		if (numClicks >= cpuCost) {
			setNumClicks(numClicks - (float)cpuCost);
			incCPUQty();
			setCPUCost(cpuCost * 1000);
		}
	}
	
	public void PurchaseGPU() {
		if ((numClicks >= gpuCost) && getCPUQty() > 0) {
			setNumClicks(numClicks - (float)gpuCost);
			incGPUQty();
			setGPUCost(gpuCost * 100);
		}
	}
}
