﻿
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{
    public List<GameArtData> collectionList;

    public void AddData(GameArtData obj)
    {
        for (var i = 0; i < collectionList.Count; i++)
        {
            if (!collectionList.Contains(obj))
            {
                collectionList.Add(obj);
            }
        }
    }

   public void RemoveLastItem()
        {
            if (collectionList.Contains(item:null))
            {
                collectionList.RemoveAt(collectionList.Count-1);
            }
            
        }
        
}
