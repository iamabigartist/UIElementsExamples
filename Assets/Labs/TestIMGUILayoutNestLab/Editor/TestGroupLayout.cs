using UnityEditor;
using UnityEngine;
namespace Labs.TestIMGUILayoutNestLab.Editor
{
	public class TestGroupLayout : EditorWindow
	{
		[MenuItem("Labs/Labs.TestIMGUILayoutNestLab.Editor/TestGroupLayout")]
		static void ShowWindow()
		{
			var window = GetWindow<TestGroupLayout>();
			window.titleContent = new("TestGroupLayout");
			window.Show();
		}

		void OnGUI()
		{
			// GUI.BeginGroup(new(50f, 50f, 200f, 200f), GUI.skin.window);
			// {
			// 	GUI.Label(new(0, 0, 150f, 60f), new GUIContent("(0,0,100,100) label"), GUI.skin.window);
			// 	GUI.Label(new(0, 60f, 150f, 60f), new GUIContent("(0,0,100,100) label"), GUI.skin.window);
			// 	using (var g = new GUI.GroupScope(new(50, 120, 150, 80), GUI.skin.window))
			// 	{
			// 		GUILayout.Label("Layout Label");
			// 		GUILayout.Label("Layout Label");
			// 		GUILayout.Label("Layout Label");
			// 		GUILayout.Label("Layout Label");
			// 	}
			// 	GUILayout.Window(100, new(0, 0, 150f, 60f), (id) =>
			// 	{
			// 		GUILayout.Label("Layout Label");
			// 		GUILayout.Label("Layout Label");
			// 		GUILayout.Label("Layout Label");
			// 		GUILayout.Label("Layout Label");
			// 	}, "Layout Window");
			// }
			// GUI.EndGroup();
			//
			// if (GUI.Button(new(350, 350, 100, 100), "BelowButton"))
			// {
			// 	Debug.Log("Below Button Clicked");
			// }
			// using (var g = new GUI.GroupScope(new(350, 350, 300, 300), GUI.skin.window))
			// {
			// 	if (GUILayout.Button("Above Button"))
			// 	{
			// 		Debug.Log("Above Button Clicked");
			// 	}
			// }

			GUILayout.BeginHorizontal(GUI.skin.box);

			GUILayout.Button("111", GUI.skin.textArea);
			GUILayout.Button("111", GUI.skin.textArea);
			GUILayout.Button("111", GUI.skin.textArea);
			GUILayout.Button("111", GUI.skin.textArea);

			GUILayout.EndHorizontal();
		}
	}
}