using System.Collections;
using UnityEngine;
using UnityEngine.Assertions;

namespace Akular
{
    public class ARSceneBehaviour : MonoBehaviour
    {
        [SerializeField]
        private ARLoadingBehaviour _arLoading = null;

        [SerializeField]
        private ARMovementBehaviour _arMovement = null;

        private void Awake()
        {
            Assert.IsNotNull(_arLoading);
            Assert.IsNotNull(_arMovement);

            SetLoadingActive(true);
        }

        private void Start()
        {
            StartCoroutine(LoadAssetAndEnableMovement());
        }

        private void SetLoadingActive(bool active)
        {
            _arLoading.gameObject.SetActive(active);
            _arMovement.gameObject.SetActive(!active);
        }

        private IEnumerator LoadAssetAndEnableMovement()
        {
            yield return new WaitForSeconds(2f);

            var asset = AssetLoadUtility.LoadStreamingAsset(Constants.BUNDLE_ANDROID_FILENAME);

            if (asset != null)
            {
                var assetInstance = Instantiate(asset);
                assetInstance.transform.position = Camera.main.transform.position;

                SetLoadingActive(false);
                _arMovement.EnableMovement();
            }
        }
    }
}