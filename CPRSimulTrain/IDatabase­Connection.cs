﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRSimulTrain
{
  public interface IDatabaseConnection
  {
    SQLite.SQLiteConnection DbConnection();
  }
}
