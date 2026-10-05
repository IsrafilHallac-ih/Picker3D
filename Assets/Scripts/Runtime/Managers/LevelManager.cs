using Runtime.Data.ValueObjects;
using UnityEngine;

namespace Runtime.Managers
{
    public class LevelManager : MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField] private Transform levelHolder;
        [SerializeField] private byte totalLevelCount;

        #endregion
       
         #region Private Variables
         private byte _currentLevel;
         private LevelData _levelData;

         #endregion

         #endregion

    }
}