using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtisanProductsCopyQuality
{
    internal class Config
    {
        internal readonly HashSet<string> machinesToTarget;// = new() { "(BC)17", "(BC)12", "(BC)15", "(BC)16", "(BC)24", "(BC)19", "(BC)Dehydrator", "(BC)FishSmoker" };

        public Config()
        {
            machinesToTarget = new() { "(BC)17", "(BC)12", "(BC)15", "(BC)16", "(BC)24", "(BC)19", "(BC)Dehydrator", "(BC)FishSmoker" };
        }
    }
}
