﻿using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    List<Objective> m_Objectives = new List<Objective>();

    public int ObjectiveCount { get { return m_Objectives.Count; } }

    public int ObjectivesCompleted {
        get {
            int count = 0;
            foreach(var objective in m_Objectives) {
                if (objective.isCompleted)
                    count++;
            }
            return count;
        }
    }

    public bool AreAllObjectivesCompleted()
    {
        if (m_Objectives.Count == 0)
            return false;

        for (int i = 0; i < m_Objectives.Count; i++)
        {
            // pass every objectives to check if they have been completed
            if (m_Objectives[i].isBlocking())
            {
                // break the loop as soon as we find one uncompleted objective
                return false;
            }
        }

        // found no uncompleted objective
        return true;
    }

    public void RegisterObjective(Objective objective)
    {
        m_Objectives.Add(objective);
    }
}
