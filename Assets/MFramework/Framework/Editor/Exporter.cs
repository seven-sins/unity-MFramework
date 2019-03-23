﻿using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace MFramework
{
    public class Exporter
    {

        private static string GenerateUnityPackageName()
        {
            return "MFramework_" + DateTime.Now.ToString("yyyyMMdd_HH");
        }

        [MenuItem("MFramework/Framework/Editor/导出UnityPackage %e", false, 1)]
        private static void MenuClicked()
        {
            EditorUtil.ExportPackage("Assets/MFramework", Exporter.GenerateUnityPackageName() + ".unitypackage");
            EditorUtil.OpenInFolder(Path.Combine(Application.dataPath, "../"));
        }
    }

}

