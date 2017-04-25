using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace Maticsoft.Model
{
    //Dynatown
    public class Dynatown
    {

        /// <summary>
        /// id
        /// </summary>		
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// accnumber
        /// </summary>		
        private string _accnumber;
        public string accnumber
        {
            get { return _accnumber; }
            set { _accnumber = value; }
        }
        /// <summary>
        /// Dyname
        /// </summary>		
        private string _dyname;
        public string Dyname
        {
            get { return _dyname; }
            set { _dyname = value; }
        }
        /// <summary>
        /// tel
        /// </summary>		
        private string _tel;
        public string tel
        {
            get { return _tel; }
            set { _tel = value; }
        }
        /// <summary>
        /// company
        /// </summary>		
        private string _company;
        public string company
        {
            get { return _company; }
            set { _company = value; }
        }
        /// <summary>
        /// flag
        /// </summary>		
        private string _flag;
        public string flag
        {
            get { return _flag; }
            set { _flag = value; }
        }
        /// <summary>
        /// createdate
        /// </summary>		
        private DateTime _createdate;
        public DateTime createdate
        {
            get { return _createdate; }
            set { _createdate = value; }
        }

    }
}

