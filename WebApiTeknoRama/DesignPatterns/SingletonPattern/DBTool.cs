using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiTeknoRama.Models.Context;

namespace WebApiTeknoRama.DesignPatterns.SingletonPattern
{
    public class DBTool
    {
        public DBTool()
        {

        }

        static MyContext _dbInstance;

        public static MyContext DBInstance
        {
            get
            {
                if (_dbInstance == null) _dbInstance = new MyContext();
                return _dbInstance;
            }
        }

        
    }
}