using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archive : MonoBehaviour
{
    public List<GameObject> comicList = new List<GameObject> ();

    public GameObject debugComic;
    void Start()
    {
        
    }
    [ContextMenu("Debug add")]
    public void debugAdd() { comicList.Add(debugComic); }
    [ContextMenu("Clear Archive")]
    public void clearArchive() { comicList.Clear(); }
    public void addComic2Archive(GameObject comic)
    {
        comicList.Add(comic);
    }
    public GameObject getComic(int id)
    {
        if (id < comicList.Count)
        {
            return comicList[id];
        }
        else
        {
            return null;
        }
    }
}
