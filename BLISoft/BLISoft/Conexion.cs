﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace BLISoft
{
    public static class Conexion
    {
        public readonly static string ConectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BLISoft.Properties.Settings.bliConnectionString1last"].ConnectionString;
    }
}
