using Rails.Rendering;
using UnityEngine;

namespace Rails.ScriptableObjects
{
    [CreateAssetMenu(fileName = "PlayerTemplate", menuName = "ScriptableObjects/Players/PlayerTokenTemplate", order = 2)]
    public class PlayerTokenTemplate : ScriptableObject
    {
        [SerializeField]
        private string _trainName;
        public string TrainName => _trainName;

        [SerializeField]
        private GameToken _baseTrainToken;
        public GameToken BaseTrainToken => _baseTrainToken;

        [SerializeField]
        private GameToken _fastTrainToken;
        public GameToken FastTrainToken => _fastTrainToken;

        [SerializeField]
        private GameToken _heavyTrainToken;
        public GameToken HeavyTrainToken => _heavyTrainToken;

        [SerializeField]
        private GameToken _superTrainToken;
        public GameToken SuperTrainToken => _superTrainToken;

        [SerializeField]
        private GameToken _railToken;
        public GameToken RailToken => _railToken;
    }
}