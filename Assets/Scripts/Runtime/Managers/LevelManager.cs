using System;
using Runtime.Commands.Level;
using Runtime.Data.UnityObjects;
using Runtime.Data.ValueObjects;
using UnityEngine;
using Object = UnityEngine.Object;

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

        private OnLevelLoaderCommand _levelLoadCommand;
        private OnLevelDestroyedCommand _levelDestroyCommand;

        private byte _currentLevel;
        private LevelData _levelData;

        #endregion

        #endregion

        private void Awake()
        {
            _levelData = GetLevelData();
            _currentLevel = GetActiveLevel();

            Init();
        }

        private void Init()
        {
            _levelLoadCommand = new OnLevelLoaderCommand(levelHolder);
            _levelDestroyCommand = new OnLevelDestroyedCommand(levelHolder);
        }



        private LevelData GetLevelData()
        {
            return Resources.Load<CD_Level>("Data/CD_Level").Levels[_currentLevel];
        }


        private byte GetActiveLevel()
        {
            return _currentLevel;
        }

        private void OnEnable()
        {
            SubscribeEvents();

        }

        private static void SubscribeEvents()
        {
           // CoreGameSignals.Instance.onLevelInitialize += _levelLoadCommand.Execute();
            
        }
    }

}  