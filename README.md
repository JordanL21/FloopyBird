**Jordan's Flappy Bird Dev Progress**
- Base Flappy Bird game created
- Ding trigger sound added
- Game over sound added
- Game over if bird goes off screen added
- Pipe speed and spawn distance changed
- Cloud particle system added
- Title Screen added
- Wings animated and added to bird
**BUGS TO FIX/TO DO**
- Score increases after game over (FIXED)
- High score does not stay after game resets (FIXED)
- Title Screen not transitioning to Game Screen (FIXED)
- Assign wing animation to flap on spacebar click(COMPLETED)
- Add a back to title screen button (COMPLETED)
- Add an exit program button on Title Screen (COMPLETED)
- Add Pause Screen (COMPLETED)
- Bug where bird stays paused if you go back to the home screen and press play (FIXED)
- Bug where pause and game over screen appear at the same time (FIXED)
- **ERROR(S) ON BUILD**
- When bird falls below "transform.position.y < -18", gameOverSFX does not trigger
- After pausing the game and pressing the resume button, if you pause the game thereafter the spacebar will un-pause the game
- Unable to find player assembly: E:\FlappyBird\Temp\StagingArea\Data\Managed\UnityEngine.TestRunner.dll
  UnityEngine.Debug:LogWarning (object)
  Unity.Burst.Editor.BurstAotCompiler:OnPostBuildPlayerScriptDLLsImpl (UnityEditor.Build.Reporting.BuildReport) (atLibrary/PackageCache/com.unity.burst@1.6.6/Editor/BurstAotCompiler.cs:350)
  Unity.Burst.Editor.BurstAotCompiler:OnPostBuildPlayerScriptDLLs (UnityEditor.Build.Reporting.BuildReport) (atLibrary/PackageCache/com.unity.burst@1.6.6/Editor/BurstAotCompiler.cs:208)
  UnityEngine.GUIUtility:ProcessEvent (int,intptr,bool&)
