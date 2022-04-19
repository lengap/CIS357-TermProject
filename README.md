# CIS357-TermProject

## Tutorial
### Overview
Unity is a real-time development platform used to build high-quality 3D and 2D games. Unity’s software allows creators to easily build and deploy their game or application across mobile, desktop, VR/AR, game consoles, or the Web. Our application “Insert Name Here” is an Android game designed, developed, and built using the Unity software.
Getting Started
To get started download the Unity game engine hub and log in if prompted by the application. Once the software is installed and set up, you will be greeted with a GUI that lets you view your Unity Engine installs, Projects, a Learn tab that contains tutorials, and a community tab. 
To add a new Unity installation click the “Installs” tab on the left (See Fig. 1). Once in the “Installs” window we want to click “Install Editor”, this will create a pop-up window containing the current versions of the Unity Engine. For this project, we want to pick version “2021.2.19f1”. Once selecting the latest version, we want to install all the platforms we wish to deploy our application. In our case, we only want to install the “Android Build Support” and “Android SDK & NDK Tools” options (See Fig. 2). Once the proper options have been selected, click “Continue” and accept the Terms and Conditions. You have now downloaded Unity and the Android Build Platform for our app. 
Now that you have Unity installed, let's create our Unity project. Head back into the “Projects” tab (See Fig. 1), and click on “New Project”. You will be presented with a “New Project” window that contains templates, guides, and samples. For this project, we want to select the “2D Mobile Core” template. This template comes preloaded with the recommended packages and settings for developing a mobile application (Note: You may have to download the 2D Mobile template depending on your Unity Version). Once you have the template selected, direct your attention to the right part of the window and fill in the project name and location you wish the project to be installed. Once your project has a name and location, click “Create Project” and allow time for your project to be created. By now you should have the Unity editor installed and your Project created, now you’re ready to get started.

### Step-by-step Coding Instructions
Step 1: Changing Build Type
Open up the Unity Editor by clicking on your newly created project. When the editor finishes its initial start-up process you will be greeted with the “Editor Window” (Fig. 3). From here we want to change the build settings from “Windows, Mac, Linux” to “Android”. To do this go to File -> Build Settings and change to “Android”. Once The build settings have changed we can begin creating the app!
Step 2: Creating the UI Canvas
The first step in creating an app in Unity is to create a UI Canvas. The UI Canvas will be used to hold all our UI elements (panels, text, buttons, etc.). 
    2a. Creating the UI Canvas
To do this right-click on the “Hierarchy” (Leftmost Section of the Editor. Fig 4.) and go down to the “UI” section of the dropdown and select the “Canvas” object. Once the canvas is created you will see a large outline appear in the “Scene” window (Centermost window).

2b. Adjusting the UI Canvas to fit within our view.
To adjust the canvas to fit within the view we want to adjust the “Render Mode” from being “Screen Space - Overlay” to “Screen Space - Camera”. This can be done by having the Canvas object selected and looking for “Render Mode” in the “Inspector Window” (Rightmost Window of the Editor.)

When the Canvas’s “Render Mode” is changed to be “Screen Space - Camera” we need to apply a camera object into the “Render Camera” field of the inspector window. To apply the camera we can click and drag the “Main Camera” object from the hierarchy window into the field. 

By now your UI Canvas object should fit within the view of the phone!
Step 3: Creating the UI Panels
The UI Panels will be used to easily swap between what is being shown to the end-user.

To create the UI Panels we add a new UI Object following the same steps in Step 2, but this time we want to click on Panel. This will automatically create a UI Panel that will be the child object of our Canvas. (Repeat this step two additional times).

Once we have the three Panels, we want to resize them to create three different areas. One for our main button, another to hold the counter, and another to hold the toolbar of the app. 

To resize the panels, we can change the value of the anchor points in the inspector menu (See Fig. 5), or by dragging the small blue dots on the corners of each panel.

Step 4: Implementing Toolbar, Main Button, and Counter. (Main Panel)
    4a. Creating the Toolbar
To create the toolbar we need to select the toolbar panel you created in Step 3. From there we want to create 3 UI Buttons. To create the buttons right-click on the toolbar panel and select UI -> “Button - Text Mesh Pro”. These buttons will be used to change what is being displayed to the user.

Once the buttons are created we want to resize them so each will fit within the bounds of the toolbar panel. To do this we can either use Transform Mode (Fig. 6) or change the width and height fields within the Inspector window.

4b. Styling the Toolbar
To add an image to the Toolbar we need to change the Source Image field within the Inspector window (Fig. 7) to the image we want to display.


    4c. Creating the Main Button
To create the main button we need to create a new UI Button (See Step 4a) in the main panel of the app. Once we have the button, we need to resize the button to fit within the dimensions of the main panel (See Step 4a). Once the button is sized appropriately we need to remove the child text object and add an image object (UI -> Image).

4d. Creating the Counter Text
To create the counter text we need to create a new UI Text. To create the text field right-click on the counter panel and select UI -> Legacy -> Text. We want to use the Legacy text because it allows for easy interaction with scripts.

When we have the Text field we need to resize it to fit within the bounds of the counter panel. We can do this by using the Transform mode (See Fig. 6) or by adjusting the width and height in the Inspector window.

Now that we’ve created our UI Panels and populated them with the appropriate UI elements your app should look like this (See Fig. 8).
Step 5: Designing the Store Panel.
The store panel will be the page where all the upgrades for the game will be stored. We’ll need a parent panel with three children panels for the items.

    5a. Creating the Parent Store Panel
To create the Parent Store Panel follow the steps in Step 3 and rename the panel to “StorePanel”.
    5b. Creating the Children Panels
To create the children panels, right-click on the Parent Panel and select UI -> Panel. Once we have one panel created we want to design it so we can duplicate it to make our lives easier.

Start by adding UI Button (See Previous Steps) this button will take up the width of the phone screen, with a height of 291 pixels (See previous steps for help with changing dimensions).

Right-click the UI Button and add a UI Image (UI -> Image) from the hierarchy window. From there we want to select the item image from the asset window and drag it into the “Source Image” field in the inspector window.

Right-click the UI Button and add 4 UI Text fields (See Previous Steps), One for the item name, item cost, item quantity, and item description. 

Duplicate the child panel 2 additional times and change the image and text fields to the item names. In our case we want the images to be different computer parts, with their names corresponding to the image.

Step 6. Creating Falling Game Objects & Scripts
    6a. Creating Scripts in Unity
To create a script in unity you right-click on the “Assets” Window (Bottommost Window, Fig. 9) and go to Create -> C# Script. Rename the script to “GameScript”. This script will be the game management script that will handle each panel, button, and text of the app. 

6b. Creating the _GM Object
The _GM object will be an empty game object that will house our script and allow us to populate public (Serializable) fields within our script. To create the _GM object right-click on the “Hierarchy” window and select “Create Empty”. Once the empty object is created, rename it to “_GM”. From there we need to add our script to the object. To do this find the “Add Component” button in the inspector window and search for the GameScript. This will apply our script to the _GM object.
6c. Adding Functionality to the GameScript
Open the C# Script we created in the last part. The first thing you’ll notice is the Start and Update functions. The Start Function will contain code we need to initialize, the Update function will contain code we want to update every frame. To get started with adding functionality, we need to do is import the Unity UI Library by adding 

using UnityEngine.UI;

    
    below the other imports at the beginning of the script.

Now we want to declare all the panels we intend to modify in our application. The syntax for the declaration is below. 
[SerializeField]
    Transform MainPanel;


We need to create a declaration for each panel we intend to display (Store Panel, Main Panel, Achievements Panel, Settings Panel).
Next, we’ll need to add declarations for all the text fields we’ll need to modify while our app is running (Syntax Below).
[SerializeField]
    Text cpuQtyText;

    
We will need to create a declaration for each text field we intend to modify (Item cost, item quantity, and the number of bits).

Lastly we want to declare global variables we will be using throughout the script.
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


    6d. The Start Method
As mentioned above, the Start method should only contain variables and statements we only want to run once when our application starts. As such, we want to initialize all our global variables, text fields, and declare what panels will be visible on app start  from the previous step.
void Start()
{
QualitySettings.vSyncCount = 0; //Sets the number of vertical syncs to 0.
Application.targetFrameRate = 240; //Sets the apps target frame rate
numClicks = 0; //Start the user with 0 clicks
numClicksMult = 1; //Start the user with a click multiplier of 0
        
currPanel = "main"; // Set currentPanel to main
/**
* Declare all qty and code variables to their respective values.
*/
ramQty = 0; 
ramCost = 100;
cpuQty = 0;
cpuCost = 500;
gpuQty = 0;
gpuCost = 1000;
/**
* Declare cost fields on app start.
*/
ramCostText.text = "Cost: " + getRAMCost() + " bits";
gpuCostText.text = "Cost: " + getGPUCost() + " bits";
cpuCostText.text = "Cost: " + getCPUCost() + " bits";


/**
* Define which panels will be visible on app start
*/
ChallengesPanel.gameObject.SetActive(false);
MainPanel.gameObject.SetActive(true);
ToolsPanel.gameObject.SetActive(true);
//SettingsPanel.gameObject.SetActive(false);
StorePanel.gameObject.SetActive(false);

}


6e. The Update Function
As mentioned above, the Update function should contain any variables or fields that will need to be updated throughout the lifetime of the app. This function is executed once per frame. As such, we want to add the code related to spawning a falling object and code related to updating the number of clicks.

// Update is called once per frame
    void Update()
    {
        randomFloat = Random.Range(-2f, 2f);
        clicksText.text = ((int)numClicks) + " bits";

        if (getNumClicks() > 1000){ // temporary number, will in reality be much higher
            //change picture next to the achievement from black to a trophy
        }

        //if (){}


        if (getCPUQty() != 0) {
            numClicks += 0.01f * ((5* Mathf.Pow(1.8f, getCPUQty())) *        Mathf.Pow(2, getGPUQty()));
        }
    }


6f. Creating Setters and Getters for Each Item.
We want to make setters and getters for each item, this will make it easier to update and get the information relating to each item. The syntax is below.
void setGPUCost(int val) {
    gpuCost = val;
}
    
float getNumClicks() {
    return numClicks;
}



6g. Creating Onclick Listeners
To create onclick we need to define new functions for each button within our game. These functions will be used to purchase items, increase the count, and many additional functions. The code to for the main functions of buttons within our game is shown below.
// Code for Main Button Click
public void Click() {
        numClicks = numClicks + (1 * numClicksMult);
        Instantiate(coin, new Vector3(randomFloat, 4, 0), Quaternion.identity);
}

    
    
// Code for when a toolbar item is clicked.
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


// Code for when an item is purchased.
public void PurchaseRAMModules() {
        if (numClicks >= ramCost) {
            setNumClicks(numClicks - (float)ramCost);
            setNumClicksMult(numClicksMult * 2);
            incRAMQty();
            
        }
    }


To apply the on click listeners we need to add the function to the on click field in the inspector window of each button. To do this we need to click the “+” symbol to add a new function (See Fig. 10). From there we need to drag our “_GM” object into the Object field and select the function we want to execute when the button is clicked.


6h. Creating The Falling Object Prefab.
To create the falling objects we need to create an empty object. To do this right-click on the Hierarchy window and create an empty object. Now that we have the empty object we need to add 3 components, one for the RigidBody2D (Physics), another for the Sprite, and the last one for the Collider (Collision Detection). To add a new component to a game object follow Step 6b. 

When the object is created and has physics, colliders, and an image component we need to turn it into a “Prefab”. To create a prefab, drag the object from the “Inspector” window into the “Assets” window. 


Now that we have the script and game objects we need to populate the fields displayed in the Inspector window of the “_GM” object (See Fig. 11). To do this drag each object and panel into the fields you created earlier.


### Conclusions
### See Also
####  Tutorials and Set Up Guides
      Creating Android App in Unity
      Unity UI Creation Tutorial
      Unity Github .gitignore file
####  Resources and Assets
      CPU Image
      GPU Image
      RAM Free Image


## Presentation

## Demo Video
