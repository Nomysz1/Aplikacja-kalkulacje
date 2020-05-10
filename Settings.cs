using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    class Settings
    {
        static public bool save(string key, string val)
        {
            Console.WriteLine("Key -> {0}", key);
            try
            {
                Properties.Settings.Default[key] = val;
            } catch(Exception e)
            {
                return false;
            }
            Properties.Settings.Default.Save();
            Console.WriteLine(Properties.Settings.Default[key]);
            return true;
        }

        static public string read(string key)
        {
            try
            {
                string settings_ = Properties.Settings.Default[key].ToString();
                return settings_;
            } catch(Exception e)
            {
                return null;
            }
        }
    }
}
