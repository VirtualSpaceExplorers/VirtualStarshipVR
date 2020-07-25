# Nexus Aurora Virtual Starship Experiment
## Abstract
To create a simple experience where the user may enter and interact with features pertaining the starship. Features such as being able to navigate through other rooms using doors, ladders, or other modes of "walking" will be explored. 

## Important Details
Any and all development that is under the Nexus Aurora (NA) title will use ONLY Royalty Free and Open Source assets. If you are unsure whether or not what you create, use, or propose has not been claimed, used, or copyrighted by anyone other person, entity, or organization, please ask in the discord channel.

# Getting Started
### Download Unity Version (2019.4.0f1): https://unity3d.com/unity/qa/lts-releases
### Download Visual Studio Community 2019: https://visualstudio.microsoft.com/downloads/
- Using the Visual Studio Installer, make sure to check the "Game development with Unity" package under Workloads.
- This may not be needed if you use check this as an option within the Unity installer. If you have an older version, please uninstall and install this one. Otherwise, please make sure that the version is opening correctly the 2019. 

##### Using VS with Unity for Intellisense. 
- Close Visual Studio 
- In Unity go to edit -> preferences -> external tools.
- In external tools, go to the part that says external script editor. This should be on whichever visual studio editor you are using.
- Make sure generate all CSPROJ files is checked and edited attaching is checked.
- Open to c# script you were trying to open earlier or open the c# project. 

Fork this branch into your account. Make and explain changes if you commit. Create a PR for us to review before merging. Be as detailed as possible in your commit messages. Due to it being open source, anyone and everyone should have some basic understanding on the changes you have made and why.

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

### Helping out with modeling or optimization for models
Any 3D modeling programming may be use that allows for .fbx export. There are a few things that need to be checked for exporting to be done correctly. Blender is our choice of software as it is open source and free to the public use. Please use any version 2.8x.x and above. Current version is 2.83.3 LTS at the time of writing: [Click Here to Download Blender](https://blender.org).

![Blender Export Settings 2.8x.x](/Images/BlenderSettings.png)

Quick hotkey commands are located for your reference in /Images/BlenderHotkeys

### Discord Channel
If this project sounds interesting to you and you would like to keep in the loop of the development. Please joing our discord channel: https://discord.gg/sT2JtX. Our project is called virtual-starship. Please follow all guidelines and rules set forth by the channel and introduce yourself in the #introduce-yourself channel! 

### Unreal to Unity Developers
Were you an Unreal developer? Please see this for a better understanding and smoother transistion on the differences and similarities: https://learn.unity.com/tutorial/transitioning-from-unreal-to-unity

### Unity Documentation for 2019.4.x
https://docs.unity3d.com/Manual/index.html

# Current Features
- Implementation of a first person controller plugin that is open source and free from the Unity Marketplace
- Basic Skybox
-- Updated to space galaxy themed skybox
- Basic Ground
- Basic Model
- Basic Lighting (Baked). All models are to be static for baking to be done correctly.

# Technical Specifications
- 4 Floors
- 12 Rooms per floor
- 4 rooms per floow should have windows

# Features to Implement (New Users look here!)
- Implementation of interaction controllers using the given. Doors, ladders, picking up objects. 
- Better and/or more realisitc sky by shader or other pipeline.
- Lighting
- Audio
- Creating and optimizing models provided by @joe_mckirdy
-- Foldable Space Chairs
-- Other Props
