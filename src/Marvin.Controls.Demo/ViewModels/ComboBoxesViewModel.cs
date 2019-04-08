﻿using System.Collections.Generic;
using Caliburn.Micro;

namespace Marvin.Controls.Demo.ViewModels
{
    public class ComboBoxesViewModel : Screen
    {
        public override string DisplayName => "ComboBoxes";

        public List<string> Entries { get; }

        public List<string> LockedEntries { get; set; }

        public ComboBoxesViewModel()
        {
            Entries = new List<string>
            {
                "Entry 1",
                "Entry 2",
                "Entry 3",
                "Entry 4",
                "Entry 5"
            };

            LockedEntries = new List<string>
            {
                "Locked Entry"
            };
        }
    }
}
