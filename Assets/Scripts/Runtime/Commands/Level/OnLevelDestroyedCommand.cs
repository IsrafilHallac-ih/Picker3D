using UnityEngine;

namespace Runtime.Commands.Level
{
    public class OnLevelDestroyedCommand
    {
        private Transform _levelHolder;
        public OnLevelDestroyedCommand(Transform levelHolder)
        {
            _levelHolder=levelHolder;
        }

        public void Execute()
        {
            if(_levelHolder.transform.childCount<=0)return;  
            Object.Destroy(_levelHolder.transform.GetChild(0).gameObject);
        }
    }
}