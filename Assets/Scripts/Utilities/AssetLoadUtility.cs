using System.IO;
using UnityEngine;

namespace Akular
{
    public static class AssetLoadUtility
    {
        public static GameObject LoadStreamingAsset(string filename)
        {
            var bundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, filename));

            if (bundle == null)
            {
                Debug.LogError("Failed to load AssetBundle!");
                bundle.Unload(false);
                return null;
            }

            else
            {
                foreach (Object _asset in bundle.LoadAllAssets<GameObject>())
                {
                    if (_asset is GameObject)
                    {
                        var modelGameObject = (GameObject) _asset;
                        bundle.Unload(false);
                        return modelGameObject;
                    }
                }

                return null;
            }
        }
    }
}