using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Akular
{
    public class IntroSceneBehaviour : MonoBehaviour
    {
        [SerializeField]
        private Button _startButton = null;

        private void Awake()
        {
            Assert.IsNotNull(_startButton);

            _startButton.onClick.AddListener(() => StartARScene());
        }

        private void StartARScene()
        {
            SceneManager.LoadSceneAsync((int) SceneBuildIndex.AR);
        }
    }
}