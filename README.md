# na-virtual-starship-experimental
## Abstract
To create a simple experience where the user may enter and interact with features pertaining the starship. Features such as being able to navigate through other rooms using doors, ladders, or other modes of "walking" will be explored. 

## Coding Convention
Please follow: https://unity3d.college/2016/05/16/unity-coding-standards/.

Please comment and/or document your code. If you created a new function, please add a comment block indicating your name/username, date created/modified/edited, and what the function does.
```
// Class Implementations
*/
Author: DeadlyMagikarps
Created: 7/19/2020
Description: Class that does yada yada using yada yada
/*
public class ClassName {

   // Variables
   int initialCounter = 0;
   string someString;
   
   void DoSomething();
};

*/
Author: DeadlyMagikarps
Created: 7/18/2020, Edited: 7/19/2020
Description: Class that does yada yada using yada yada
/*
// Function Implementation Example
public void DoSomething()
   {
    int selection; 
    
    switch(selection)
       {
          case '1':
             DoSomething();
             break;
             
          default:
             DoNothing();
             break;
       }
   }
```

# Getting Started
### Download Unity Version (2019.4.0f1): https://unity3d.com/unity/qa/lts-releases
### Download Visual Studio Community 2019: https://visualstudio.microsoft.com/downloads/
- Using the Visual Studio Installer, make sure to check the "Game development with Unity" package under Workloads.
- This may not be needed if you use check this as an option within the Unity installer. If you have an older version, please uninstall and install this one. Otherwise, please make sure that the version is opening correctly the 2019. 

Fork this branch into your account. Make and explain changes if you commit. Create a PR for us to review before merging. Be as detailed as possible in your commit messages. Due to it being open source, anyone and everyone should have some basic understanding on the changes you have made and why.

### Discord Channel
If this project sounds interesting to you and you would like to keep in the loop of the development. Please joing our discord channel: https://discord.gg/sT2JtX. Our project is called virtual-starship. Please follow all guidelines and rules set forth by the channel and introduce yourself in the #introduce-yourself channel! 

Were you an Unreal developer? Please see this for a better understanding and smoother transistion on the differences and similarities: https://learn.unity.com/tutorial/transitioning-from-unreal-to-unity

### Unity Documentation for 2019.4.x
https://docs.unity3d.com/Manual/index.html

# Current Features
- Implementation of a first person controller plugin that is open source and free from the Unity Marketplace
- Basic Skybox
- Basic Ground
- Basic Model

# Features to be Implement
- Implementation of interaction controllers using the given. Doors, ladders, picking up objects. 
- Better and/or more realisitc sky by shader or other pipeline. 
- Creating and optimizing models provided by @joe_mckirdy
