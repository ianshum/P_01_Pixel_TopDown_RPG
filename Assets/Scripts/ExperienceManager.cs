using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceManager : MonoBehaviour
{
    public List<int> experienceTable;
    
    //Calculate the Level from the player's current Experience, returned value is the plain Level (not index)
    public int CalculateLevelFromExperience()
    {
        int currentLevel = 0;
        //this variable keeps track of the accumulated experience of current level
        int totalExperienceOfCurrentLevel = 0;

        //while the player has more than the accumulated experience of current level, means it has the level equal to the current level 
        while(GameManager.Instance.player.Experience >= totalExperienceOfCurrentLevel)
        {
            totalExperienceOfCurrentLevel += experienceTable[currentLevel];
            currentLevel++;

            if(currentLevel == experienceTable.Count)
                return currentLevel;
        }

        return currentLevel;
    }

    //Calculate the Accumulated Experience needed to reach the Level passed in as paramater, the Level paramter is the plain level (not index)
    public int GetAccumulatedExperienceOfLevel(int level)
    {
        int runningLevel = 0;
        int totalExperience = 0;

        while(runningLevel < level)
        {
            totalExperience += experienceTable[runningLevel];
            runningLevel++;
        }

        return totalExperience;
    }
}