using System;
using System.Collections.Generic;
using UnityEngine;

namespace spaar.ModLoader.Internal
{
  internal class Keys
  {
    private static Dictionary<string, Key> Keymap;

    private static Keys _instance;
    public static Keys K { get { return _instance; } }

    public static void Initialize()
    {
      LoadKeys();

      Configuration.OnConfigurationChange += OnConfigurationChange;

      _instance = new Keys();
    }

    private static void OnConfigurationChange(object sender, ConfigurationEventArgs a)
    {
      LoadKeys();
    }

    public static void LoadKeys()
    {
      Keymap = new Dictionary<string, Key>();

      Keymap["Console"] = new Key(Configuration.GetString("consoleK1", "LeftControl"),
        Configuration.GetString("consoleK2", "K"));
      Keymap["ObjectExplorer"] = new Key(Configuration.GetString("objExpK1", "LeftControl"),
        Configuration.GetString("objExpK2", "O"));
    }

    /// <summary>
    /// Equivalent to <c>getKey(key).IsDown()</c>
    /// </summary>
    public bool this[string key]
    {
      get
      {
        return getKey(key).IsDown();
      }
    }

    public static Key getKey(string keyName)
    {
      if (Keymap.ContainsKey(keyName))
      {
        return Keymap[keyName];
      }
      else
      {
        throw new ArgumentException("No such key: " + keyName);
      }
    }
  }
}
