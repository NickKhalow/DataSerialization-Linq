using System;
using UnityEngine;


namespace DefaultNamespace.Practice
{
    public class FindNames : MonoBehaviour
    {
        [SerializeField]
        private TextAsset textAsset;
        
        private int[] Find()
        {
            //TODO with declarative (better) style or imperative (normal) style
            //print lenght of names that starts with "N" and more than 5 characters
            throw new NotImplementedException();
        }
        
        [ContextMenu(nameof(PrintNames))]
        public void PrintNames()
        {
            print(JsonUtility.ToJson(Find()));
        }
    }
}