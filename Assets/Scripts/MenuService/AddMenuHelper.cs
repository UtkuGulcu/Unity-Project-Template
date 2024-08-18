using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class AddMenuHelper : MonoBehaviour
{
    [SerializeField] private GameObject baseMenuPrefab;

    private int lastChildCount;

    private void Update()
    {
#if !UNITY_EDITOR
        Destroy(this);
#endif

        int currentChildCount = transform.childCount;

        if (lastChildCount != currentChildCount)
        {
            ArrangeMenuPositions();
        }

        lastChildCount = currentChildCount;
    }

    public void AddMenu()
    {
        var spawnedObject = Instantiate(baseMenuPrefab, transform);
        spawnedObject.name = "Default Menu";
    }

    private void ArrangeMenuPositions()
    {
        int menuIndex = 0;
        float referenceResolutionX = GetComponent<CanvasScaler>().referenceResolution.x;

        foreach (Transform child in transform)
        {
            if (!child.GetComponent<Canvas>())
            {
                continue;
            }

            menuIndex++;
            var rectTransform = child.GetComponent<RectTransform>();

            float xPosition = menuIndex * referenceResolutionX;
            rectTransform.anchoredPosition = new Vector2(xPosition, 0);
        }
    }
}
