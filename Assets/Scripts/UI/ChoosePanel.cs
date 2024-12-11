using CoreInfo;
using GoogleImporter;
using Source.Scripts.Client.MonoBehaviours;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ChoosePanel : CustomMonoSignalListener<CoreSignals.OnTriggerEntered>
    {
        [SerializeField] private GameObject panel;
        [SerializeField] private Button firstChoice;
        [SerializeField] private Button secondChoice;
        [SerializeField] private Button thirdChoice;
        [SerializeField] private TMP_Text term;
        [SerializeField] private TMP_Text firstTranslation;
        [SerializeField] private TMP_Text secondTranslation;
        [SerializeField] private TMP_Text thirdTranslation;
        private CoreSignals.OnTranslationChosen _firstSignal;
        private CoreSignals.OnTranslationChosen _secondSignal;
        private CoreSignals.OnTranslationChosen _thirdSignal;

        private void Start()
        {
            firstChoice.onClick.AddListener(FirstButtonClicked);
            secondChoice.onClick.AddListener(SecondButtonClicked);
            thirdChoice.onClick.AddListener(ThirdButtonClicked);
        }


        private void FirstButtonClicked()
        {
            panel.SetActive(false);
            Signal.RegistryRaise(_firstSignal);
        }

        private void SecondButtonClicked()
        {
            panel.SetActive(false);
            Signal.RegistryRaise(_secondSignal);
        }

        private void ThirdButtonClicked()
        {
            panel.SetActive(false);
            Signal.RegistryRaise(_thirdSignal);
        }

        protected override void OnSignal(CoreSignals.OnTriggerEntered data)
        {
            var combination = DependenciesContainer.GameStorage.config.GetRandomCombination();
            term.text = combination.Item1;
            firstTranslation.text = combination.Item2[0];
            
            _firstSignal = new CoreSignals.OnTranslationChosen
            {
                ChosenTranslation = combination.Item2[0],
                RightAnswer = combination.Item2[3]
            };
            secondTranslation.text = combination.Item2[1];
            
            _secondSignal = new CoreSignals.OnTranslationChosen
            {
                ChosenTranslation = combination.Item2[1],
                RightAnswer = combination.Item2[3]
            };

            thirdTranslation.text = combination.Item2[2];
            
            _thirdSignal = new CoreSignals.OnTranslationChosen
            {
                ChosenTranslation = combination.Item2[2],
                RightAnswer = combination.Item2[3]
            };

            panel.SetActive(true);
        }
    }
}