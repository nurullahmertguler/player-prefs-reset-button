using UnityEditor;
using UnityEngine;


namespace UnityToolbarExtender.Examples
{
#if UNITY_EDITOR
	static class ToolbarStyles
	{
		public static readonly GUIStyle commandButtonStyle;

		static ToolbarStyles()
		{
			commandButtonStyle = new GUIStyle("Command")
			{
				fontSize = 12,
				alignment = TextAnchor.MiddleCenter,
				imagePosition = ImagePosition.ImageAbove,
				fontStyle = FontStyle.Bold
			};
		}
	}

	
	
	[InitializeOnLoad]
	public class ScenePrefResetButton
	{
		static ScenePrefResetButton()
		{
			ToolbarExtender.LeftToolbarGUI.Add(OnToolbarGUI);
		}

		static void OnToolbarGUI()
		{
			GUILayout.FlexibleSpace();

			if (GUILayout.Button(new GUIContent("Reset", "PlayerPrefs reset"), ToolbarStyles.commandButtonStyle))
			{
				PlayerPrefs.DeleteAll();
			}
		}
	}
#endif
}
