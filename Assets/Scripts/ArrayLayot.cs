using System.Collections;
using UnityEngine;

[System.Serializable]
public class ArrayLayot
{
    [System.Serializable]
    public struct rowData
    {
        public bool[] row;
    }
    public Grid grid;
    public rowData[] rows = new rowData[10];
}
