using UnityEngine;
    public class IDCompareBehavior : MonoBehaviour
    {
        public void CompareID(int idToCompare)
            {
                int[] idList = { /* populate your IDList here */ };

                // Compare the given ID against the IDList
                bool found = false;
                foreach (int id in idList)
                {
                    if (id == idToCompare)
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    Debug.Log("ID found in the IDList");
                }
                else
                {
                    Debug.Log("ID not found in the IDList");
                }
            }
    }



 
    