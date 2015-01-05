﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace AtmosphereAutopilot
{
    static class GUIStyles
    {
        public static GUIStyle labelStyle;
        public static GUIStyle textBoxStyle;
        public static GUIStyle toggleButtonStyle;

        public static void Init()
        {
            labelStyle = new GUIStyle(GUI.skin.label);
            labelStyle.alignment = TextAnchor.MiddleCenter;
            labelStyle.fontSize = 11;
            labelStyle.margin = new RectOffset(2, 2, 1, 1);

            textBoxStyle = new GUIStyle(GUI.skin.textField);
            textBoxStyle.alignment = TextAnchor.MiddleCenter;
            textBoxStyle.fontSize = 11;
            textBoxStyle.margin = new RectOffset(2, 2, 1, 1);

            toggleButtonStyle = new GUIStyle(GUI.skin.button);
            toggleButtonStyle.alignment = TextAnchor.MiddleCenter;
            toggleButtonStyle.margin = new RectOffset(4, 4, 1, 1);
            toggleButtonStyle.fontSize = 12;
            toggleButtonStyle.stretchWidth = true;
        }
    }
}
