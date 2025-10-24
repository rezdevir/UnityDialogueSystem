using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "ReadMe_", menuName = "ReadMe")]
public class ReadMeSO : ScriptableObject
{
    [SerializeField] public bool Edit_Me=true;

    [SerializeField] public string header ="This is Header";
    
    [SerializeField] public string text ="For saving, set Edit_Me Off";
    
  
}
