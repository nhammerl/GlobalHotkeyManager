﻿using nhammerlGlobalHotkeyPluginLib;
using System.Windows.Forms;

namespace nhammerl.WindowOrganizer
{
    public class TestMessageThrower1 : IGlobalHotkeyPlugin
    {
        public string PluginName
        {
            get { return "MessageThrower1"; }
        }

        public void Execute()
        {
            MessageBox.Show("TestMessage Thrower1");
        }
    }
}