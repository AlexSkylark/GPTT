using System;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GPTT
{

    [DefaultExecutionOrder(9999)]
    public class LostAndFoundNodeElement : MonoBehaviour
    {
        private RectTransform Anchor;
        private const int SPACER_MARGIN = 6;

        public void AnchorObject(Transform transformAnchor, int spacing)
        {
            Anchor = transformAnchor.GetComponent<RectTransform>();
        }

        void Update()
        {
            // Continuously reset the´position to follow the anchor
            if (Anchor != null)
            {
                transform.position = new Vector2(Anchor.position.x - (Anchor.sizeDelta.x / 2),
                    Anchor.position.y + (Anchor.sizeDelta.y / 2) + SPACER_MARGIN);
            }
        }
    }

    class Utilities
    {
        public static void DestroyObjectsWithComponent<T>(Transform parent) where T : Component
        {
            // Find all objects in the scene that have the specified component
            T[] objectsWithComponent = parent.GetComponentsInChildren<T>();
            Debug.Log($"[GPTT-LostAndFoundProcessor] Found {objectsWithComponent.Length} GameObjects with component: {typeof(T).Name}."); 

            // Iterate through each object and destroy its GameObject
            foreach (T obj in objectsWithComponent)
            {
                Debug.Log($"[GPTT-LostAndFoundProcessor] Destroying GameObject: {obj.gameObject.name} with component: {typeof(T).Name}");
                GameObject.Destroy(obj.gameObject);
            }
        }

        public static string FindPartMod(AvailablePart part)
        {
            var configs = GameDatabase.Instance.GetConfigs("PART");

            UrlDir.UrlConfig config = Array.Find<UrlDir.UrlConfig>(configs, (c => (part.name == c.name.Replace('_', '.').Replace(' ', '.'))));
            if (config == null)
            {
                config = Array.Find<UrlDir.UrlConfig>(configs, (c => (part.name == c.name)));
                if (config == null)
                    return "";
            }
            var id = new UrlDir.UrlIdentifier(config.url);
            return id[0];
        }

        public static GameObject CreateHeaderPrefab(string modName)
        {
            // Create the parent GameObject for the header
            GameObject header = new GameObject("ModHeader");
            RectTransform headerRectTransform = header.AddComponent<RectTransform>();
            headerRectTransform.sizeDelta = new Vector2(270, 20); // Adjust size for visibility
            headerRectTransform.anchorMin = Vector2.zero;
            headerRectTransform.anchorMax = Vector2.one;
            headerRectTransform.pivot = new Vector2(0, 0); // Center pivot

            // Add an optional background
            Image background = header.AddComponent<Image>();
            background.color = new Color(0.1f, 0.1f, 0.1f, 0.55f); // Semi-transparent dark background

            // Create the Text child for displaying the mod name
            GameObject textObject = new GameObject("ModNameText");
            textObject.transform.SetParent(header.transform, false);

            RectTransform textRectTransform = textObject.AddComponent<RectTransform>();
            textRectTransform.anchorMin = new Vector2(0, 0); // Stretch to fill the parent
            textRectTransform.anchorMax = new Vector2(1, 1);
            textRectTransform.sizeDelta = Vector2.zero; // No extra size
            textRectTransform.pivot = new Vector2(0f, 0.5f); // Center pivot

            // Configure the TextMeshProUGUI component
            TextMeshProUGUI modNameText = textObject.AddComponent<TextMeshProUGUI>();
            modNameText.text = $"Parts from mod \"{modName}\":";
            modNameText.font = UISkinManager.TMPFont; // Use the KSP UI font
            modNameText.margin = new Vector4(12, 4, 4, 4); // Set text margins
            modNameText.overflowMode = TextOverflowModes.Truncate; // Prevent text overflow
            modNameText.enableWordWrapping = false; // Disable word wrapping
            modNameText.fontSize = 11;
            modNameText.fontWeight = 800;
            modNameText.alignment = TextAlignmentOptions.MidlineLeft; // Center align
            modNameText.color = Color.white;

            // Ensure proper layering for UI rendering
            header.SetLayerRecursive(LayerMask.NameToLayer("UI"));

            // Return the header GameObject
            return header;
        }
    }
}
