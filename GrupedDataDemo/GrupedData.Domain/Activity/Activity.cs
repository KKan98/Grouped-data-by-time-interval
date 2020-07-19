using System;
using System.Collections.Generic;
using System.Text;

namespace GrupedData.Domain.Activity
{
    public class Activity
    {
        private readonly string _commandActivity;
        private readonly string _commandDescription;
        private readonly string _commandDate;
        

        public Activity(string commandActivity, string commandDescription, string commandDate)
        {
            _commandActivity = commandActivity;
            _commandDescription = commandDescription;
            _commandDate = commandDate;
        }
    }
}
