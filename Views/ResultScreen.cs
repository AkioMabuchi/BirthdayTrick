using System;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Views
{
    [RequireComponent(typeof(CanvasGroup))]
    public class ResultScreen : MonoBehaviour
    {
        [SerializeField] private CanvasGroup canvasGroup;

        [SerializeField] private TextMeshProUGUI textMeshProResult;
        
        [SerializeField] private Button buttonTitle;

        public IObservable<Unit> OnClickButtonTitle => buttonTitle.OnClickAsObservable();
        
        private void Reset()
        {
            canvasGroup = GetComponent<CanvasGroup>();
        }

        public void SerResultNumber(int resultNumber)
        {
            Debug.Log(resultNumber);
            
            if (resultNumber > 0)
            {
                textMeshProResult.text = resultNumber + "日生まれです！！";
            }
            else
            {
                textMeshProResult.text = "<size=80>このゲームのトリックを理解してますね？</size>";
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
