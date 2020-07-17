using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
