#nullable enable
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;


namespace DefaultNamespace
{
    [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
    public class Character : MonoBehaviour
    {
        [SerializeField] private ExampleCharacterData data = new();


        [ContextMenu(nameof(SerializeWithUnity))]
        public void SerializeWithUnity()
        {
            print(JsonUtility.ToJson(Infill()));
        }


        [ContextMenu(nameof(SerializeWithNewton))]
        public void SerializeWithNewton()
        {
            print(JsonConvert.SerializeObject(Infill()));
        }


        private ExampleCharacterData Infill()
        {
            data.armor = new Dictionary<string, int>()
            {
                ["Helmet"] = 10,
                ["ChestPlate"] = 25
            };
            return data;
        }
    }
}