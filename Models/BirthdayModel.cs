using System;
using System.Collections.Generic;
using UniRx;

namespace Models
{
    public class BirthdayModel
    {
        private readonly ReactiveCollection<List<int>> _reactiveCollectionBirthdayNumbers = new()
        {
            new List<int>
            {
                1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31
            },
            new List<int>
            {
                2, 3, 6, 7, 10, 11, 14, 15, 18, 19, 22, 23, 26, 27, 30, 31
            },
            new List<int>
            {
                4, 5, 6, 7, 12, 13, 14, 15, 20, 21, 22, 23, 28, 29, 30, 31
            },
            new List<int>
            {
                8, 9, 10, 11, 12, 13, 14, 15, 24, 25, 26, 27, 28, 29, 30, 31
            },
            new List<int>
            {
                16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31
            }
        };

        public IEnumerable<int> BirthdayNumbers =>
            _reactiveCollectionBirthdayNumbers[_reactiveCollectionIndexes[_reactivePropertyCurrentIndexesIndex.Value]]; 

        private readonly ReactiveProperty<int> _reactivePropertyResultNumber = new(0);
        public IObservable<int> OnChangedResultNumber => _reactivePropertyResultNumber;

        private readonly ReactiveCollection<int> _reactiveCollectionIndexes = new()
        {
            0, 1, 2, 3, 4
        };

        private readonly ReactiveProperty<int> _reactivePropertyCurrentIndexesIndex = new(0);
        public bool IsFinished => _reactivePropertyCurrentIndexesIndex.Value >= _reactiveCollectionIndexes.Count;
        
        public void Initialize()
        {
            for (var i = _reactiveCollectionIndexes.Count - 1; i > 1; i--)
            {
                var j = UnityEngine.Random.Range(0, i);
                var tmp = _reactiveCollectionIndexes[i];
                _reactiveCollectionIndexes[i] = _reactiveCollectionIndexes[j];
                _reactiveCollectionIndexes[j] = tmp;
            }

            _reactivePropertyResultNumber.Value = 0;
            
            _reactivePropertyCurrentIndexesIndex.Value = 0;
        }

        public void OnAnsweredYes()
        {
            _reactivePropertyResultNumber.Value |=
                1 << _reactiveCollectionIndexes[_reactivePropertyCurrentIndexesIndex.Value];
        }

        public void IncreaseIndexesIndex()
        {
            _reactivePropertyCurrentIndexesIndex.Value++;
        }
    }
}