﻿using System;
using UnityEditor;
using UnityEngine;

namespace Elona.Slot {
	[CustomEditor(typeof (TweenSprite))]
	internal class TweenSpriteEditor : Editor {
		public static TweenSprite.TSTween[] tweens;

		public override void OnInspectorGUI() {
			base.OnInspectorGUI();
			TweenSprite t = target as TweenSprite;
			GUILayout.Space(20);
			if (GUILayout.Button("Copy Tweens")) {
				tweens = t.tweens;
			}
			if (tweens != null && GUILayout.Button("Pase Tweens")) {
				Array.Copy(tweens, t.tweens, tweens.Length);
				EditorUtility.SetDirty(t);
				tweens = null;
			}
		}
	}
}