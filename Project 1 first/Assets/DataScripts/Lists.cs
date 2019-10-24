using System.Collections.Generic;
using UnityEngine;

namespace DataScripts
{
    [CreateAssetMenu]
    public class Lists : ScriptableObject
    {
        public List<string> stringList;
        public List<float> floatList;
        public List<int> intList;

        public List<GameObject> objectList;
        public List<FloatData> dataList;
    
    }
}
