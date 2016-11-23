﻿using System;
using System.Collections;
using System.Security.Cryptography;
using System.IO;
using SimpleJSON;
using spaar.ModLoader.UI;
using UnityEngine;

namespace spaar.ModLoader.Internal
{
  public class UpdateChecker : SingleInstance<UpdateChecker>
  {
    public override string Name { get { return "spaar's Mod Loader: Updates"; } }

    public bool UpdateAvailable { get; private set; }

    private bool closed = false;
    private int windowID = Util.GetWindowID();
    private Rect windowRect = new Rect(200, 200, 370, 175);

    private IEnumerator Start()
    {
      ModLoader.MakeModule(this);

      if (!Configuration.GetBool("enableUpdateChecker", true)) yield break;

      var www = new WWW(
        "https://api.github.com/repos/spaar/besiege-modloader/releases/latest");

      yield return www;

      if (!www.isDone || !string.IsNullOrEmpty(www.error))
      {
        Debug.LogError("Update check failed: " + www.error);
        yield break;
      }

      string response = www.text;

      var release = JSON.Parse(response);
      var newestVersionS = release["tag_name"];
      var newestVersion = new Version(newestVersionS);

      var myVersion = ModLoader.ModLoaderVersion;

      if (newestVersion > myVersion)
      {
        UpdateAvailable = true;
        Debug.Log("There is a new update for the mod loader available!");
      }
    }

    private void OnGUI()
    {
      if (!UpdateAvailable || closed) return;

      GUI.skin = ModGUI.Skin;

      windowRect = GUI.Window(windowID, windowRect, DoWindow, "Update");
      windowRect = Util.PreventOffScreenWindow(windowRect);
    }

    private void DoWindow(int id)
    {
        GUILayout.TextField("An updated version of the mod loader is available!"
                           + "\nIt is recommended to update as soon as possible."
                           + "\nCheck back in the forum or open the installer"
                           + "\nagain to update!");
      if (GUILayout.Button("Close"))
      {
        closed = true;
      }

      GUI.DragWindow();
    }
  }
}
