using System;
using System.Collections.Generic;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Views
{
    [RequireComponent(typeof(CanvasGroup))]
    public class MainScreen : MonoBehaviour
    {
        [SerializeField] private CanvasGroup canvasGroup;

        [SerializeField] private TextMeshProUGUI[] textMeshProsNumbers = new TextMeshProUGUI[16];
        [SerializeField] private Button buttonYes;
        [SerializeField] private Button buttonNo;

        public IObservable<Unit> OnClickButtonYes => buttonYes.OnClickAsObservable();
        public IObservable<Unit> OnClickButtonNo => buttonNo.OnClickAsObservable();
        private void Reset()
        {
            canvasGroup = GetComponent<CanvasGroup>();
        }

        public void SetNumbers(IEnumerable<int> numbers)
        {
            var viewNumbers = new List<int>(numbers);

            for (var i = viewNumbers.Count - 1; i > 1; i--)
            {
                var j = UnityEngine.Random.Range(0, i);
                (viewNumbers[i], viewNumbers[j]) = (viewNumbers[j], viewNumbers[i]);
            }

            for (var i = 0; i < viewNumbers.Count && i < textMeshProsNumbers.Length; i++)
            {
                textMeshProsNumbers[i].text = viewNumbers[i].ToString();
            }
        }
        
        public void Show()
        {
            canvasGroup.alpha = 1.0f;
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
        }

        public void Hide()
        {
            canvasGroup.alpha = 0.0f;
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;
        }
    }
}
